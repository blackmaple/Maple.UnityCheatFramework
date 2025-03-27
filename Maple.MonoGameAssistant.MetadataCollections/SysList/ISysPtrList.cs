using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    public interface ISysPtrList<TVALUE>
        where TVALUE : unmanaged
    {
        PMonoArray<TVALUE> Items { get; }
        int Size { get; }
    }


}
