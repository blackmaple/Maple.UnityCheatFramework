using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoDescriptionClassDTO : MonoDescriptionMemberDTO
    {
        public byte[]? Utf8ImageName { get; }
        public byte[]? Utf8Namespace { get; }
        public byte[]? Utf8ClassName { get; }
    }

}
