namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         interface IContextMetadataCollectorBase
    {
        object GetClassMetadataCollection(ulong code);
    }


}
