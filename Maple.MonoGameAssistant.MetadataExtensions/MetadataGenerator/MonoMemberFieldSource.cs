namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         readonly struct MonoMemberFieldSource(nint runtimeField, int fieldOffset)
    {
        public readonly nint RuntimeField { get; } = runtimeField;
        public readonly int FieldOffset { get; } = fieldOffset;
    }
}
