using System.IO;

namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{
    public interface IClassMetadataCollectorBase<T_RefMetadata, T_PtrMetadata> : IClassMetadataCollectorCode
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {

    }

    public interface IClassMetadataCollectorCode
    {
        MonoMethodDelegate GetMethodDelegate(ulong code);
        nint GetMethodPointer(ulong code);
        int GetMemberFieldOffset(ulong code);
        nint GetStaticInstancePointer(ulong code);
    }
}
