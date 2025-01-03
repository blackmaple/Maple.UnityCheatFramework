
namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
#pragma warning disable CS9113 // 参数未读。
    internal class MonoJsonFieldDTO(ulong code, byte[]? utf8Name, byte[]? utf8Type, bool isStatic)
#pragma warning restore CS9113 // 参数未读。
    {

    }
#else
    public class MonoJsonFieldDTO : Maple.MonoGameAssistant.Model.MonoDescriptionFieldDTO
    {
        public MonoJsonFieldDTO(ulong code, byte[]? utf8Name, byte[]? utf8Type, bool isStatic)
        {
            this.Code = code;
            this.Utf8Name = utf8Name;
            this.Utf8FieldType = utf8Type;
        }
    }
#endif 


}
