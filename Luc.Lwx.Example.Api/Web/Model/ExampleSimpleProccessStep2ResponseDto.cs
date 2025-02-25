using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Luc.Lwx.Example.Api.Web.Model;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
    public class ExampleSimpleProccessStep2ResponseDto
    {
        [JsonPropertyName("ok")] [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public required bool Ok { get; set; }
    }