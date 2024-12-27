namespace Maple.MonoGameAssistant.MetadataModel.Model
{
    public readonly struct MonoMemberFieldSource(nint runtimeField, int fieldOffset)
    {
        public readonly nint RuntimeField { get; } = runtimeField;
        public readonly int FieldOffset { get; } = fieldOffset;
    }
}
