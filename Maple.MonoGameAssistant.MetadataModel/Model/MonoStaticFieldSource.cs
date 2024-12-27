namespace Maple.MonoGameAssistant.MetadataModel.Model
{

    public readonly struct MonoStaticFieldSource(nint runtimeField, nint sourceClass)
    {
        public readonly nint RuntimeField { get; } = runtimeField;
        public readonly nint SourceClass { get; } = sourceClass;

    }
}
