namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         readonly struct MonoStaticFieldSource(nint runtimeField, nint sourceClass)
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint RuntimeField = runtimeField;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint SourceClass = sourceClass;

    }
}
