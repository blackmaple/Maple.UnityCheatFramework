using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.Metadata
{
    public interface IClassMetadataCollector : MetadataModel.ClassMetadata.IClassMetadataCollector
    {
        abstract static ulong CODE { get; }
    }


    //public interface IPtrMetadata<T_PtrMetadata> : IPtrMetadata
    //    where T_PtrMetadata : unmanaged, IPtrMetadata, IPtrMetadata<T_PtrMetadata>
    //{
    //    static abstract implicit operator T_PtrMetadata(nint ptr);
    //    static abstract implicit operator nint(T_PtrMetadata ptr);
    //    static abstract implicit operator bool(T_PtrMetadata ptr);
    //}
}
