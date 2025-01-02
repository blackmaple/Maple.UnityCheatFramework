using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class MonoJsonClassDTO : MonoJsonMemberDTO
    {
        public byte[]? Utf8ImageName { get; set; }
        public byte[]? Utf8Namespace { get; set; }
        public byte[]? Utf8ClassName { get; set; }
    }

}
