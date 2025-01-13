using System.Text.Json.Serialization;

namespace Luc.Lwx.Example.Api;

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(decimal))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessCancelRequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessCancelResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessFinishRequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessFinishResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStartRequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStartResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStep1RequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStep1ResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStep2RequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStep2ResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessEndpointListResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessEndpointListProccessResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleSimpleProccessStatusResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleParamInPathCancelResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleParamInPathFinishRequestDto))]
[JsonSerializable(typeof(Web.Model.ExampleParamInPathFinishResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampleParamInPathStartRequestDto))]
[JsonSerializable(typeof(Web.Model.ExampelParamInPathStartResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampelParamInPathStep1RequestDto))]
[JsonSerializable(typeof(Web.Model.ExampelParamInPathStep1ResponseDto))]
[JsonSerializable(typeof(Web.Model.ExampelParamInPathStep2RequestDto))]
[JsonSerializable(typeof(Web.Model.ExampelParamInPathStep2ResponseDto))]
public partial class SourceGenerationContext : JsonSerializerContext
{    
}
