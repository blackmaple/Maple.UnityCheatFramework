
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
#pragma warning disable CS9113 // 参数未读。
    internal class MonoJsonClassDTO(ulong code, byte[]? utf8ImageName, byte[]? utf8Namespace, byte[]? utf8ClassName, byte[]? utf8FullName)
#pragma warning restore CS9113 // 参数未读。
    {

    }
#else
    public class MonoJsonClassDTO : Maple.MonoGameAssistant.Model.MonoDescriptionClassDTO
    {
        public MonoJsonClassDTO(ulong code, byte[]? utf8ImageName, byte[]? utf8Namespace, byte[]? utf8ClassName, byte[]? utf8FullName)
        {


            this.Code = code;
            this.Utf8ImageName = utf8ImageName;
            this.Utf8Namespace = utf8Namespace;
            this.Utf8ClassName = utf8ClassName;
            this.Utf8Name = utf8FullName;

        }
    }
#endif 


}
