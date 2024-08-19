using System.Net;
using BlazorMonaco.Editor;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Jellyfin.HardwareVisualizer.Client.Service.Http;
using Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

namespace Jellyfin.HardwareVisualizer.Client.Pages;

public partial class SubmitSurveyResultPage
{
	public SubmitSurveyResultPage()
	{
		ValidationErrors = new List<Error>();
	}

	[Inject]
	public IJSRuntime JsRuntime { get; set; }

	[Inject]
	public HttpService HttpService { get; set; }

	[Inject]
	public NavigationManager NavigationManager { get; set; }

	public List<Error> ValidationErrors { get; set; }

	private StandaloneCodeEditor _editor;
	private JSchema _jsonSchema;

	public bool IsSchemaValid { get; set; }

	private StandaloneEditorConstructionOptions EditorConstructionOptions(StandaloneCodeEditor editor)
	{
		return new StandaloneEditorConstructionOptions
		{
			AutomaticLayout = true,
			Language = "json",
			Value = """
   {
   }
   """,
		};
	}

	protected override async Task OnInitializedAsync()
	{
		_jsonSchema = JSchema.Parse(await HttpService.SubmissionApiAccessor.GetSubmitSchema().Unpack());
	}

	public async Task SubmitResults()
	{
		string value;
		try
		{
			var textModel = await this._editor.GetModel();
			value = await textModel.GetValue(EndOfLinePreference.TextDefined, false);
		}
		catch (Exception ex)
		{
			ValidationErrors.Add(new Error()
			{
				Column = 0,
				Line = 0,
				Message = $"Could not get text from editor. Please try again: {ex.Message}",
				Path = ""
			});
			Console.WriteLine(ex);
			return;
		}
		try
		{
			ValidateSubmission(value);
			if (!IsSchemaValid)
			{
				return;
			}
		}
		catch (Exception ex)
		{
			ValidationErrors.Add(new Error()
			{
				Column = 0,
				Line = 0,
				Message = $"Could not validate submission. Please try again: {ex.Message}",
				Path = ""
			});
			Console.WriteLine(ex);
			return;
		}

		var postAsync = await HttpService.SubmissionApiAccessor.SubmitResults(value);
		if (postAsync.StatusCode == HttpStatusCode.OK)
		{
			var id = postAsync.Object;
			NavigationManager.NavigateTo($"/survey?submission={WebUtility.UrlDecode(id)}");
		}
		else if (postAsync.StatusCode == HttpStatusCode.BadRequest && postAsync.ErrorResult is not null)
		{
			var problemDetails = postAsync.ErrorResult;
			ValidationErrors.AddRange(problemDetails.Errors.SelectMany(e => e.Value.Select(f => new Error()
			{
				Path = e.Key,
				Message = f
			})));
		}
		else if (postAsync.StatusCode == HttpStatusCode.GatewayTimeout)
		{			
			ValidationErrors.Add(new Error()
			{
				Column = 0,
				Line = 0,
				Message = $"You are currently rate limited. Please try again in {postAsync.StatusMessage}",
				Path = ""
			});
		}
		else
		{	
			ValidationErrors.Add(new Error()
			{
				Column = 0,
				Line = 0,
				Message = $"Unkown error submitting the result: {postAsync.StatusMessage} - {postAsync.Object}",
				Path = ""
			});
		}
	}

	private async Task OnEditorInitialized()
	{
		var model = await this._editor.GetModel();

		await JsRuntime.InvokeVoidAsync("setModelJsonSchema", model.Uri, _jsonSchema.ToString());
	}

	private async Task OnValueChanged(ModelContentChangedEvent arg)
	{
		var textModel = await this._editor.GetModel();
		var value = await textModel.GetValue(EndOfLinePreference.TextDefined, false);
		ValidateSubmission(value);
	}

	private void ValidateSubmission(string value)
	{
		ValidationErrors.Clear();
		try
		{
			var jObject = JObject.Parse(value);
			IsSchemaValid = jObject.IsValid(_jsonSchema, out IList<ValidationError> errors);

			ValidationErrors.AddRange(errors.Select(e => new Error()
			{
				Message = e.Message,
				Column = e.LinePosition,
				Line = e.LineNumber,
				Path = e.Path,
			}));
		}
		catch (Exception e)
		{
			IsSchemaValid = false;
			ValidationErrors.Add(new Error()
			{
				Message = "Unknown issue occurred while validating the input."
			});
		}
	}

	public class Error
	{
		public int Line { get; set; }
		public int Column { get; set; }
		public string Message { get; set; }
		public string Path { get; set; }
	}
}