namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class MonoJsonFieldDTO : MonoJsonMemberDTO
    {
        public byte[]? Utf8FieldType { get; set; }

        public bool IsStatic { get; set; }
    }

}
