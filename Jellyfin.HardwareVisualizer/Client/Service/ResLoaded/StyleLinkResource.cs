using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public class StyleLinkResource : HtmlResourceBase, IEquatable<StyleLinkResource>
{
	private readonly string _url;

	public StyleLinkResource(string url)
	{
		_url = url;
	}

	public override RenderFragment Render()
	{
		return __builder =>
		{
			__builder.OpenElement(0, "link");
			__builder.AddAttribute(1, "href", _url);
			__builder.AddAttribute(2, "rel", "stylesheet");
			__builder.AddAttribute(3, "onload", EventCallback.Factory.Create(this, () => OnLoaded.Raise().AsTask()));
			__builder.CloseElement();
		};
	}

	public bool Equals(StyleLinkResource other)
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

	public override bool Equals(IHtmlResource? other)
	{
		return Equals((object)other);
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

		return Equals((StyleLinkResource)obj);
	}

	public override int GetHashCode()
	{
		return (_url != null ? _url.GetHashCode() : 0);
	}
}