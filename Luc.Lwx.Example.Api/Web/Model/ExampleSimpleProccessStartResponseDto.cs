using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Luc.Lwx.Example.Api.Web.Model;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
    public class ExampleSimpleProccessStartResponseDto
    {
        [JsonPropertyName("ok")] [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Ok { get; set; }

        [JsonPropertyName("proc-id")] [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long ProcId { get; set; }
    }
