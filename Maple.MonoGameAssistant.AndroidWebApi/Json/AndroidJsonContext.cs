using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    [JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = false,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    PropertyNameCaseInsensitive = true,
    Converters = [typeof(IntPtrJsonConverter), typeof(UIntPtrJsonConverter)])]

    [JsonSerializable(typeof(AndroidWebApiNotifyDTO))]
    [JsonSerializable(typeof(MonoResultDTO<AndroidSessionInfoDTO>))]
    public partial class AndroidJsonContext : JsonSerializerContext
    {

    }
}
