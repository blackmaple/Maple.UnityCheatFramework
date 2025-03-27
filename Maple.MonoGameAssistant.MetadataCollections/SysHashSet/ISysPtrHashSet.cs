using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    public interface ISysPtrHashSet<TVALUE>
    where TVALUE : unmanaged
    {
        int Count { get; }
        int LastIndex { get; }
        PMonoArray<Ref_MonoSlot<TVALUE>> Slots { get; }

    }

}
