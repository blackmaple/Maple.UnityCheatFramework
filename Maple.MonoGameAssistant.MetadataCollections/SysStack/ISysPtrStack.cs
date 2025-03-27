using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    public interface ISysPtrStack<TVALUE> where TVALUE : unmanaged
    {
        int Size { get; }
        PMonoArray<TVALUE> Array { get; }

    }


}
