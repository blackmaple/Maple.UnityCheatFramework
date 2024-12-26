namespace Maple.MonoGameAssistant.MetadataModel.Model
{
    public readonly struct MonoFieldSource(nint sourceClass, nint runtimeField, int fieldOffset)
    {
        public readonly nint SourceClass { get; } = sourceClass;
        public readonly nint RuntimeField { get; } = runtimeField;
        public readonly int FieldOffset { get; } = fieldOffset;
    }

}
