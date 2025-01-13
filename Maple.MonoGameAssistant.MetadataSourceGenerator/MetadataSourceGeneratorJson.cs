//using System.Text.Encodings.Web;
//using System.Text.Json;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public static class MetadataSourceGeneratorJson
    {
        //        static JsonSerializerOptions JsonSerializer { get; } = new JsonSerializerOptions()
        //        {
        //            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        //            WriteIndented = false,
        //            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
        //            PropertyNameCaseInsensitive = true,
        //            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        //        };

        //        static string Object2JsonContent<T>(T obj)
        //        {
        //            var jsonString = System.Text.Json.JsonSerializer.Serialize(obj, JsonSerializer);
        //            return jsonString;
        //        }

        //        public static bool WriteJson2File(ClassMemberMetadataData classMemberMetadataData)
        //        {
        //            var projectPath = classMemberMetadataData.ProjectPath;
        //#pragma warning disable RS1035 // 不要使用禁用于分析器的 API
        //            if (Directory.Exists(projectPath))
        //            {
        //                var subPath = Path.Combine(projectPath, "MetadataJson");
        //                if (!Directory.Exists(subPath))
        //                {
        //                    Directory.CreateDirectory(subPath);
        //                }
        //                var filePath = Path.Combine(subPath, $"{classMemberMetadataData.ContextSymbol.ToDisplayString()}.json");
        //                var jsonString = Object2JsonContent(classMemberMetadataData.GetJsonCollectionDTO());
        //                File.WriteAllText(filePath, jsonString);
        //                return true;
        //            }
        //            return false;
        //#pragma warning restore RS1035 // 不要使用禁用于分析器的 API
        //        }


        public static bool WriteJson2File(ClassMemberMetadataData _) => false;
    }
}
