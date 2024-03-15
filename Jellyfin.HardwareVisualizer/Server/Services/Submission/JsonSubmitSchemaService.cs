using Jellyfin.HardwareVisualizer.Shared.Models;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

public interface IJsonSubmitSchemaService
{
	string GetSubmitSchema();
}

[SingletonService(typeof(IJsonSubmitSchemaService))]
public class JsonSubmitSchemaService : IJsonSubmitSchemaService
{
	public JsonSubmitSchemaService()
	{
		GenerateJsonSchema();
	}

	public string JsonSubmitSchema { get; set; }

	private void GenerateJsonSchema()
	{
		var jSchemaGenerator = new JSchemaGenerator();
		jSchemaGenerator.DefaultRequired = Required.DisallowNull;
		jSchemaGenerator.ContractResolver = new DefaultContractResolver()
		{
			NamingStrategy = new SnakeCaseNamingStrategy(true, true, true)
		};
		JsonSubmitSchema = jSchemaGenerator.Generate(typeof(TranscodeSubmission)).ToString();
	}

	public string GetSubmitSchema()
	{
		return JsonSubmitSchema;
	}
}