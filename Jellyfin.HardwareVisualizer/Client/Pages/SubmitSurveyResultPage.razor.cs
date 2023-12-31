using BlazorMonaco.Editor;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Jellyfin.HardwareVisualizer.Client.Pages;

public partial class SubmitSurveyResultPage
{
	public SubmitSurveyResultPage()
	{
		ValidationErrors = new List<ValidationError>();

		var jSchemaGenerator = new JSchemaGenerator();
		jSchemaGenerator.DefaultRequired = Required.DisallowNull;
		jSchemaGenerator.ContractResolver = new DefaultContractResolver()
		{
			NamingStrategy = new SnakeCaseNamingStrategy(true, true, true)
		};
		_jsonSchema = jSchemaGenerator.Generate(typeof(TranscodeSubmission));
	}

	[Inject]
	public IJSRuntime JsRuntime { get; set; }

	public List<ValidationError> ValidationErrors { get; set; }

	private StandaloneCodeEditor _editor;
	private readonly JSchema _jsonSchema;

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

	protected override Task OnInitializedAsync()
	{
		return base.OnInitializedAsync();
	}

	private async Task OnEditorInitialized()
	{
		var model = await this._editor.GetModel();

		await JsRuntime.InvokeVoidAsync("setModelJsonSchema", model.Uri, _jsonSchema.ToString());
	}

	private async Task OnValueChanged(ModelContentChangedEvent arg)
	{
		var textModel = await this._editor.GetModel();
		ValidationErrors.Clear();
		try
		{
			var jObject = JObject.Parse(await textModel.GetValue(EndOfLinePreference.TextDefined, false));
			IsSchemaValid = jObject.IsValid(_jsonSchema, out IList<ValidationError> errors);
			
			ValidationErrors.AddRange(errors);
		}
		catch (Exception e)
		{
			IsSchemaValid = false;
		}
	}
}