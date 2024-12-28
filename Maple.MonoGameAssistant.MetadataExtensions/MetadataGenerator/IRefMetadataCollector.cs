namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         interface IRefMetadataCollector<T_RefMetadata>
       where T_RefMetadata : unmanaged, IRefMetadata
    {

    }
}
