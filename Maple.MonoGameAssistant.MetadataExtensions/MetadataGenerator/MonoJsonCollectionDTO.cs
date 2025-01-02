namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class MonoJsonCollectionDTO
    {
        public MonoJsonClassDTO[]? Classes { get; set; }
        public MonoJsonFieldDTO[]? Fields { get; set; }
        public MonoJsonMethodDTO[]? Methods { get; set; }
    }
}
