using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Luc.Lwx.Example.Api.Web.Model;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
    public class ExampleSimpleProccessEndpointListResponseDto
    {
        [JsonPropertyName("ok")] [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]                 
        public required bool Ok { get; set; }
        
        [JsonPropertyName("proc-list")] [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]                 
        public ExampleSimpleProccessEndpointListProccessResponseDto[]? ProcList { get; set; }
    }

