using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.OverlayDraw;

[SingletonService()]
public class OverlayDrawOrderService
{
    public OverlayDrawOrderService()
    {
        _handlers = new Dictionary<int, OverlayHandler>();
    }

    public int OverlayDrawOrder { get; private set; } = 0;
    private IDictionary<int, OverlayHandler> _handlers;

    public OverlayHandler Reserve()
    {
        var item = OverlayDrawOrder++;
        return _handlers[item] = new OverlayHandler(item, this);
    }

    public async ValueTask Return(int order)
    {
        _handlers.Remove(order);
        OverlayDrawOrder--;
        foreach (var (_, value) in _handlers.Where(e => e.Key >= OverlayDrawOrder))
        {
            await value.Update();
        }
    }
}

public class OverlayHandler : AsyncDisposable
{
    private int Order { get; set; }

    public ValueTask Update()
    {
        Order--;

        return OrderItem.Raise(Order);
    }

    public PubSubEvent<int> OrderItem { get; }

    public OverlayHandler(int order, OverlayDrawOrderService drawOrderService) : base(() => Return(drawOrderService, order))
    {
        Order = order;
        OrderItem = new PubSubEvent<int>();
    }

    private static ValueTask Return(OverlayDrawOrderService drawOrderService, int order)
    {
        return drawOrderService.Return(order);
    }
}