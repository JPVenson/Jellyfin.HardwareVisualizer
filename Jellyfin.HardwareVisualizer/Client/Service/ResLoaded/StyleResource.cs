using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public class StyleResource : HtmlResourceBase, IEquatable<StyleResource>
{
	private readonly string _styleContent;

	public StyleResource(string styleContent)
	{
		_styleContent = styleContent;
		OnLoaded = null;
	}

	public override RenderFragment Render()
	{
		return __builder =>
		{
			__builder.OpenElement(0, "style");
			__builder.AddContent(1, _styleContent);
			__builder.CloseElement();
		};
	}

	public bool Equals(StyleResource other)
	{
		if (ReferenceEquals(null, other))
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		return _styleContent == other._styleContent;
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

		return Equals((StyleResource)obj);
	}

	public override int GetHashCode()
	{
		return (_styleContent != null ? _styleContent.GetHashCode() : 0);
	}
}