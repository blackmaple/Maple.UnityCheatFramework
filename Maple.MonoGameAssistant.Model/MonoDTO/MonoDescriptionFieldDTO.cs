namespace Maple.MonoGameAssistant.Model
{
    public class MonoDescriptionFieldDTO : MonoDescriptionMemberDTO
    {
        public byte[]? Utf8FieldType { get; set; }

        public bool IsStatic { get; set; }
    }

}
