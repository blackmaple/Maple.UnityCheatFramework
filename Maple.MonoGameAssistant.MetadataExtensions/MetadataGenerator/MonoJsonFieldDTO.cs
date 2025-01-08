
namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal class MonoJsonFieldDTO(ulong code, byte[]? utf8Name, byte[]? utf8Type, bool isStatic)
    {
        public ulong Code { get; } = code;
        public byte[]? Utf8Name { get; } = utf8Name;
        public byte[]? Utf8FieldType { get; } = utf8Type;
        public bool IsStatic { get; } = isStatic;

    }
#else
    public class MonoJsonFieldDTO : Maple.MonoGameAssistant.Model.MonoDescriptionFieldDTO
    {
        public MonoJsonFieldDTO(ulong code, byte[]? utf8Name, byte[]? utf8Type, bool isStatic)
        {
            this.Code = code;
            this.Utf8Name = utf8Name;
            this.Utf8FieldType = utf8Type;
            this.IsStatic = isStatic;
        }
    }
#endif 


}
