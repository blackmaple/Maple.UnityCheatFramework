

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal class MonoJsonMethodDTO(ulong code, byte[]? utf8name, byte[]?[]? utf8Parameters, byte[]? utf8ReturnType)
    {
        public ulong Code { get; } = code;
        public byte[]? Utf8Name { get; } = utf8name;
        public byte[]?[]? Utf8Parameters { get; } = utf8Parameters;
        public byte[]? Utf8ReturnType { get; } = utf8ReturnType;

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
