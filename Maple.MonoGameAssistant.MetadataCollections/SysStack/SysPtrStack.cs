namespace Maple.MonoGameAssistant.MetadataCollections
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct SysPtrStack<TVALUE>(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
    where TVALUE : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly System.IntPtr m_Pointer = ptr;
        public System.IntPtr Ptr => m_Pointer;

        public static implicit operator SysPtrStack<TVALUE>(System.IntPtr ptr) => new SysPtrStack<TVALUE>(ptr);
        public static implicit operator System.IntPtr(SysPtrStack<TVALUE> ptr) => ptr.m_Pointer;
        public static implicit operator bool(SysPtrStack<TVALUE> ptr) => ptr.m_Pointer != System.IntPtr.Zero;


        public override string ToString()
        {
            return m_Pointer.ToString("X8");
        }
    }


}
