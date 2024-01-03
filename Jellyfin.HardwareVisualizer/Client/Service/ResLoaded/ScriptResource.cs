using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public class ScriptResource : HtmlResourceBase, IEquatable<ScriptResource>
{
	private readonly string _scriptContent;

	public ScriptResource(string scriptContent)
	{
		_scriptContent = scriptContent;
		OnLoaded = null;
	}

	public override RenderFragment Render()
	{
		return __builder =>
		{
			__builder.OpenElement(0, "script");
			__builder.AddAttribute(1, "type", "text/javascript");
			__builder.AddAttribute(2, "language", "javascript");
			__builder.AddContent(3, _scriptContent);
			__builder.CloseElement();
		};
	}

	public override bool Equals(IHtmlResource? other)
	{
		return Equals((object)other);
	}

	public bool Equals(ScriptResource other)
	{
		if (ReferenceEquals(null, other))
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		return _scriptContent == other._scriptContent;
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

		return Equals((ScriptResource)obj);
	}

	public override int GetHashCode()
	{
		return (_scriptContent != null ? _scriptContent.GetHashCode() : 0);
	}
}