using System.Reflection;
using System.Text.Json.Serialization;
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
		jSchemaGenerator.ContractResolver = new JsonDotNetResolver()
		{
			NamingStrategy = new SnakeCaseNamingStrategy(true, true, true),
		};
		
		JsonSubmitSchema = jSchemaGenerator.Generate(typeof(TranscodeSubmission)).ToString();
	}

	public string GetSubmitSchema()
	{
		return JsonSubmitSchema;
	}

	public class JsonDotNetResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			var jsonProperty = base.CreateProperty(member, memberSerialization);

			var jsonPropertyNameAttribute = member.GetCustomAttribute<JsonPropertyNameAttribute>();
			if (jsonPropertyNameAttribute is not null)
			{
				jsonProperty.PropertyName = jsonPropertyNameAttribute.Name;
			}

			return jsonProperty;
		}
	}
}