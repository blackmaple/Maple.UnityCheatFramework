using Maple.MonoGameAssistant.Core;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{

    public interface ISysPtrList<TVALUE>
        where TVALUE : unmanaged
    {
        PMonoArray<TVALUE> Items { get; }
        int Size { get; }
    }

    public interface ISysPtrDictionary<TKEY, TVALUE>
        where TKEY : unmanaged
        where TVALUE : unmanaged
    {
        int Count { get; }
        int FreeCount { get; }
        int Size => Count - FreeCount;
        PMonoArray<Ref_MonoEntry<TKEY, TVALUE>> Entries { get; }


    }

    public interface ISysPtrHashSet<TVALUE>
        where TVALUE : unmanaged
    {
        int Count { get; }
        int LastIndex { get; }
        PMonoArray<Ref_MonoSlot<TVALUE>> Slots { get; }

    }

    public interface ISysPtrQueue<TVALUE> where TVALUE : unmanaged
    {
        int Size { get; }
        PMonoArray<TVALUE> Array { get; }
        int Head { get; }
    }

    public interface ISysPtrStack<TVALUE> where TVALUE : unmanaged
    {
        int Size { get; }
        PMonoArray<TVALUE> Array { get; }

    }


    public static class SysCollectionsExtensions
    {

        public static ReadOnlySpan<TVALUE> PtrListAsReadOnlySpan<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {

            var items = @this.Items;
            var count = @this.Size;
            return items.AsReadOnlySpan(count);
        }
        public static Span<TVALUE> PtrListAsSpan<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            var items = @this.Items;
            var count = @this.Size;
            return items.AsSpan(count);
        }
        public static ref TVALUE PtrListRefElementAt<T, TVALUE>(this T @this, int index)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            return ref @this.Items.RefElementAt(index);
        }
        public static IEnumerable<TVALUE> PtrListAsEnumerable<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            var count = @this.Size;
            var items = @this.Items;
            for (int i = 0; i < count; ++i)
            {
                yield return items.RefElementAt(i);
            }
        }
        public static TVALUE[] PtrListToArray<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            return @this.PtrListAsReadOnlySpan<T, TVALUE>().ToArray();
        }



        public static PMonoEntry<Ref_MonoEntry<TKEY, TVALUE>, TKEY, TVALUE>[] PtrDictionaryAsRefArray<T, TKEY, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrDictionary<TKEY, TVALUE>
            where TKEY : unmanaged
            where TVALUE : unmanaged
        {
            var arrCount = @this.Count;
            var realCount = arrCount - @this.FreeCount;
            if (realCount == 0)
            {
                return [];
            }
            var span_entries = @this.Entries.AsReadOnlySpan(arrCount);
            var ret_keyValues = new PMonoEntry<Ref_MonoEntry<TKEY, TVALUE>, TKEY, TVALUE>[realCount];
            int index = 0;
            foreach (ref readonly var ref_entry in span_entries)
            {
                if (ref_entry.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_entry).AsPointer();
                    ret_keyValues[index % ret_keyValues.Length] = ptr;
                    ++index;
                }
            }
            return ret_keyValues;
        }

        public static PMonoSlot<Ref_MonoSlot<TVALUE>, TVALUE>[] PtrHashSetAsRefArray<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrHashSet<TVALUE>
            where TVALUE : unmanaged
        {
            var realCount = @this.Count;
            if (realCount == 0)
            {
                return [];
            }
            var arrCount = @this.LastIndex;
            var span_Slots = @this.Slots.AsReadOnlySpan(arrCount);
            var ret_Values = new PMonoSlot<Ref_MonoSlot<TVALUE>, TVALUE>[realCount];
            int index = 0;
            foreach (ref readonly var ref_Slot in span_Slots)
            {
                if (ref_Slot.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_Slot).AsPointer();
                    ret_Values[index % ret_Values.Length] = ptr;
                    ++index;
                }
            }
            return ret_Values;

        }

        public static Ptr_MonoItem<TVALUE>[] PtrQueueAsRefArray<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrQueue<TVALUE>
             where TVALUE : unmanaged
        {
            var realSize = @this.Size;
            if (realSize == 0)
            {
                return [];
            }
            var ret_value = new Ptr_MonoItem<TVALUE>[realSize];

            ref var ref_array = ref @this.Array.AsRef();
            var capacity = @this.Size;
            var head = @this.Head;

            for (int i = 0; i < realSize; ++i)
            {
                var arrayIndex = (head + i);
                if (arrayIndex >= capacity)
                {
                    arrayIndex -= capacity;
                }
                ref var val = ref ref_array.RefElementAt<Ref_MonoArray, TVALUE>(arrayIndex);
                var ptr_val = val.AsPointer();
                ret_value[i % ret_value.Length] = ptr_val;
            }
            return ret_value;
        }
        public static IEnumerable<Ptr_MonoItem<TVALUE>> PtrQueueAsEnumerable<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrQueue<TVALUE>
             where TVALUE : unmanaged
        {
            var realSize = @this.Size;
            if (realSize == 0)
            {
                yield break;
            }
            // ref var ref_array = ref @this.Array.AsRef();
            var array = @this.Array;
            var capacity = @this.Size;
            var head = @this.Head;
            for (int i = 0; i < realSize; ++i)
            {
                var arrayIndex = (head + i);
                if (arrayIndex >= capacity)
                {
                    arrayIndex -= capacity;
                }
                ref var val = ref array.AsRef().RefElementAt<Ref_MonoArray, TVALUE>(arrayIndex);
                var ptr_val = val.AsPointer();
                yield return ptr_val;
            }

        }

        public static Ptr_MonoItem<TVALUE>[] PtrStackAsRefArray<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrStack<TVALUE>
            where TVALUE : unmanaged
        {
            var realSize = @this.Size;
            if (realSize == 0)
            {
                return [];
            }
            var ret_value = new Ptr_MonoItem<TVALUE>[realSize];
            ref var ref_array = ref @this.Array.AsRef();
            for (int i = 0; i < realSize; i++)
            {
                ref var val = ref ref_array.RefElementAt<Ref_MonoArray, TVALUE>(realSize - i - 1);
                var ptr_val = val.AsPointer();
                ret_value[i % ret_value.Length] = ptr_val;
            }
            return ret_value;

        }
        public static IEnumerable<Ptr_MonoItem<TVALUE>> PtrStackAsEnumerable<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrStack<TVALUE>
            where TVALUE : unmanaged
        {
            var realSize = @this.Size;
            if (realSize == 0)
            {
                yield break;
            }
            //     var ret_value = new Ptr_MonoItem<TVALUE>[realSize];
            //ref var ref_array = ref @this.Array.AsRef();
            var array = @this.Array;
            for (int i = 0; i < realSize; i++)
            {
                ref var val = ref array.AsRef().RefElementAt<Ref_MonoArray, TVALUE>(realSize - i - 1);
                var ptr_val = val.AsPointer();
                yield return ptr_val;
            }


        }
        public static Span<TVALUE> PtrStackAsSpan<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrStack<TVALUE>
            where TVALUE : unmanaged
        {
            var size = @this.Size;
            var items = @this.Array;
            return items.AsSpan(size);
        }
    }



}
