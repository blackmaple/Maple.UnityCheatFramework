namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         interface IClassMetadataCollector
    {
        MonoMethodDelegate GetMethodDelegate(ulong code);
        nint GetMethodPointer(ulong code);

        MonoMemberFieldSource GetMemberFieldMetadata(ulong code);
        MonoStaticFieldSource GetStaticFieldMetadata(ulong code);

        int GetMemberFieldOffset(ulong code);
        nint GetStaticFieldValueAsPointer(ulong code);


    }
}
