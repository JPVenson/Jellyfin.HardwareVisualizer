using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public class ScriptLinkResource : HtmlResourceBase, IEquatable<ScriptLinkResource>
{
	private readonly string _url;

	public ScriptLinkResource(string url)
	{
		_url = url;
	}

	public override RenderFragment Render()
	{
		return __builder =>
		{
			__builder.OpenElement(0, "script");
			__builder.AddAttribute(1, "src", _url);
			__builder.AddAttribute(2, "type", "text/javascript");
			__builder.AddAttribute(3, "language", "javascript");
			__builder.AddAttribute(4, "onload", EventCallback.Factory.Create(this, () => OnLoaded.Raise().AsTask()));
			__builder.CloseElement();
		};
	}

	public override bool Equals(IHtmlResource? other)
	{
		return Equals((object)other);
	}

	public bool Equals(ScriptLinkResource other)
	{
		if (ReferenceEquals(null, other))
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		return _url == other._url;
	}

	public override bool Equals(object obj)
	{
		if (ReferenceEquals(null, obj))
		{
			return false;
		}

		if (ReferenceEquals(this, obj))
		{
			return true;
		}

		if (obj.GetType() != this.GetType())
		{
			return false;
		}

		return Equals((ScriptLinkResource)obj);
	}

	public override int GetHashCode()
	{
		return (_url != null ? _url.GetHashCode() : 0);
	}
}