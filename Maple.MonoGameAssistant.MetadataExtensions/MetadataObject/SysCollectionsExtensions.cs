using Maple.MonoGameAssistant.Core;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{


    public interface ISysPtrList<TVALUE>
        where TVALUE : unmanaged
    {
        public PMonoArray<TVALUE> Items { get; }
        public int Size { get; }
    }

    public interface ISysPtrDictionary<TKEY, TVALUE>
        where TKEY : unmanaged
        where TVALUE : unmanaged
    {
        public int Count { get; }
        public int FreeCount { get; }
        public int Size => Count - FreeCount;
        public PMonoArray<Ref_MonoEntry<TKEY, TVALUE>> Entries { get; }
    }

    public interface ISysPtrHashSet<TVALUE>
        where TVALUE : unmanaged
    {
        int Count { get; }
        int LastIndex { get; }
        public PMonoArray<Ref_MonoSlot<TVALUE>> Slots { get; }

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
            var count = items.Size;
            return @this.Items.AsReadOnlySpan(count);
        }

        public static Span<TVALUE> PtrListAsSpan<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            var items = @this.Items;
            var count = items.Size;
            return @this.Items.AsSpan(count);
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
        //public static IEnumerable<TVALUE> PtrListAsEnumerable< TVALUE>(this ISysPtrList<TVALUE> @this)
        //    where TVALUE : unmanaged
        //{
        //    var count = @this.Size;
        //    var items = @this.Items;
        //    for (int i = 0; i < count; ++i)
        //    {
        //        yield return items.RefElementAt(i);
        //    }
        //}



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

        public static Ptr_MonoItem<TVALUE>[] PtrQueueToArray<T, TVALUE>(this T @this)
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

        public static Ptr_MonoItem<TVALUE>[] PtrStackToArray<T, TVALUE>(this T @this)
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

    }



}
