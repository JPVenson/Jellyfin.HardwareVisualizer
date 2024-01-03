namespace Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

public static class DictionaryExtensions
{
	public static TVal GetOrDefault<TVal, TKey>(this IDictionary<TKey, TVal> dict, TKey key, TVal fallback)
	{
		if (dict.TryGetValue(key, out var val))
		{
			return val;
		}

		return fallback;
	}
}