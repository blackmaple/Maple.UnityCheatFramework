namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{



    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         readonly struct MonoMemberFieldSource(nint runtimeField, int fieldOffset)
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint RuntimeField = runtimeField;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I4)]
        public readonly int FieldOffset = fieldOffset;


        public static implicit operator nint(MonoMemberFieldSource obj) => obj.RuntimeField;
        public static implicit operator int(MonoMemberFieldSource obj) => obj.FieldOffset;
    }
}
