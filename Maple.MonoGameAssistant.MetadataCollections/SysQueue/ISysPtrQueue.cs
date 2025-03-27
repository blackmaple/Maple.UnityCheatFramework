using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    public interface ISysPtrQueue<TVALUE> where TVALUE : unmanaged
    {
        int Size { get; }
        PMonoArray<TVALUE> Array { get; }
        int Head { get; }
    }

}
