using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    public interface ISysPtrDictionary<TKEY, TVALUE>
    where TKEY : unmanaged
    where TVALUE : unmanaged
    {
        int Count { get; }
        int FreeCount { get; }
        int Size => Count - FreeCount;
        PMonoArray<Ref_MonoEntry<TKEY, TVALUE>> Entries { get; }


    }



}
