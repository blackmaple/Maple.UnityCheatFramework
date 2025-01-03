

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
#pragma warning disable CS9113 // 参数未读。
    internal class MonoJsonMethodDTO(ulong code, byte[]? utf8name, byte[]?[]? utf8Parameters, byte[]? utf8ReturnType)
#pragma warning restore CS9113 // 参数未读。
    {

    }
#else
    public class MonoJsonMethodDTO : Maple.MonoGameAssistant.Model.MonoDescriptionMethodDTO
    {
        public MonoJsonMethodDTO(ulong code, byte[]? utf8name, byte[]?[]? utf8Parameters, byte[]? utf8ReturnType)
        {

            this.Code = code;
            this.Utf8Name = utf8name;
            this.Utf8Parameters = utf8Parameters;
            this.Utf8ReturnType = utf8ReturnType;

        }
    }
#endif 


}
