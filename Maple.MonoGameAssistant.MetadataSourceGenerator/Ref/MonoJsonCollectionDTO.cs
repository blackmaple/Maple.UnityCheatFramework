namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class MonoJsonCollectionDTO
    {
        public MonoJsonClassDTO[]? Classes { get; set; }
        public MonoJsonFieldDTO[]? Fields { get; set; }
        public MonoJsonMethodDTO[]? Methods { get; set; }
    }
}
