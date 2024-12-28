namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         readonly struct MonoStaticFieldSource(nint runtimeField, nint sourceClass)
    {
        public readonly nint RuntimeField { get; } = runtimeField;
        public readonly nint SourceClass { get; } = sourceClass;

    }
}
