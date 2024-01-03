using Jellyfin.HardwareVisualizer.Client.Service.OverlayDraw;
using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Jellyfin.HardwareVisualizer.Client.Service.WaiterIndicator;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Components;

public partial class WaiterIndicatorComponent : IDisposable, IAsyncDisposable
{
	private PubSubEvent.TrackableDisposable _isWaitingChangedHandle;
	private OverlayHandler _overlayHandle;
	private int _currentIndex;

	[Parameter]
	[Inject]
	public WaiterService WaiterService { get; set; }

	[Inject]
	public OverlayDrawOrderService OverlayDrawOrderService { get; set; }

	protected override void OnInitialized()
	{
		base.OnInitialized();
		_isWaitingChangedHandle = WaiterService.IsWaitingChanged.Register(StateHasChanged);
		_overlayHandle = OverlayDrawOrderService.Reserve();
		_overlayHandle.OrderItem.Register((idx) =>
		{
			_currentIndex = idx;
			StateHasChanged();
		});
	}

	public void Dispose()
	{
		_isWaitingChangedHandle?.Dispose();
	}

	/// <inheritdoc />
	public async ValueTask DisposeAsync()
	{
		await _overlayHandle.DisposeAsync();
	}
}