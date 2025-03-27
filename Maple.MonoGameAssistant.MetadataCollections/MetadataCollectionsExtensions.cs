using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataCollections
{

    public static class MetadataCollectionsExtensions
    {
        #region ToArray

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
        public static IEnumerable<Ptr_MonoItem<TVALUE>> PtrListAsRefEnumerable<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrList<TVALUE>
            where TVALUE : unmanaged
        {
            var count = @this.Size;
            var items = @this.Items;
            for (int i = 0; i < count; ++i)
            {
                ref var ref_item = ref items.RefElementAt(i);
                var ptr = Unsafe.AsRef(in ref_item).AsPointer();
                yield return ptr;

            }
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
        public static IEnumerable<PMonoEntry<Ref_MonoEntry<TKEY, TVALUE>, TKEY, TVALUE>> PtrDictionaryAsRefEnumerable<T, TKEY, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrDictionary<TKEY, TVALUE>
            where TKEY : unmanaged
            where TVALUE : unmanaged
        {
            var arrCount = @this.Count;
            var realCount = arrCount - @this.FreeCount;
            if (realCount == 0)
            {
                yield break;
            }
            var entries = @this.Entries;
            for (int i = 0; i < arrCount; ++i)
            {
                ref var ref_entry = ref entries.RefElementAt(i);
                if (ref_entry.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_entry).AsPointer();
                    yield return ptr;
                }
            }
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
        public static IEnumerable<PMonoSlot<Ref_MonoSlot<TVALUE>, TVALUE>> PtrHashSetAsRefEnumerable<T, TVALUE>(this T @this)
            where T : unmanaged, ISysPtrHashSet<TVALUE>
            where TVALUE : unmanaged
        {
            var realCount = @this.Count;
            if (realCount == 0)
            {
                yield break;
            }
            var arrCount = @this.LastIndex;
            var slots = @this.Slots;
            for (int i = 0; i < arrCount; ++i)
            {
                ref var ref_Slot = ref slots.RefElementAt(arrCount);
                if (ref_Slot.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_Slot).AsPointer();
                    yield return ptr;
                }
            }
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
        public static IEnumerable<Ptr_MonoItem<TVALUE>> PtrQueueAsRefEnumerable<T, TVALUE>(this T @this)
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
        public static IEnumerable<Ptr_MonoItem<TVALUE>> PtrStackAsRefEnumerable<T, TVALUE>(this T @this)
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

        static MonoRuntimeContext GetNotNullValue(this MonoRuntimeContext? monoRuntimeContext)
        {
            return monoRuntimeContext ?? MonoRuntimeContext.GlobalInstance ?? MetadataCollectorException.Throw<MonoRuntimeContext>($"{typeof(MonoRuntimeContext).FullName} IS NULL");

        }

        #endregion

        #region Dictionary<TKey, TValue>
        static SystemDictionaryGeneric<TKey, TValue>.Ptr_SystemDictionaryGeneric LoadSelf<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return SystemDictionaryGeneric<TKey, TValue>.LoadSelf(runtimeContext.GetNotNullValue(), ptr.Ptr);
        }

        public static bool Remove<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, in TKey key, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).REMOVE(key);
        }
        public static void Clear<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            ptr.LoadSelf(runtimeContext).CLEAR();
        }
        public static void Add<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, in TKey key, in TValue val, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            ptr.LoadSelf(runtimeContext).ADD(key, val);
        }
        public static int Count<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, MonoRuntimeContext? runtimeContext = default)
             where TKey : unmanaged
             where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).GET_COUNT();
        }
        public static bool ContainsKey<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, in TKey key, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).CONTAINS_KEY(key);
        }
        public static bool ContainsValue<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, in TValue val, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).CONTAINS_VALUE(val);
        }
        public static bool TryGetValue<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, in TKey key, out TValue val, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).TRY_GET_VALUE(key, MapleOut<TValue>.FromOut(out val));
        }

        public static IEnumerable<PMonoEntry<Ref_MonoEntry<TKey, TValue>, TKey, TValue>> AsRefEnumerable<TKey, TValue>(this SysPtrDictionary<TKey, TValue> ptr, MonoRuntimeContext? runtimeContext = default)
            where TKey : unmanaged
            where TValue : unmanaged
        {
            return ptr.LoadSelf(runtimeContext).AsRefEnumerable();
        }

        #endregion

        #region HashSet<T>

        public static IEnumerable<PMonoSlot<Ref_MonoSlot<T>, T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SysPtrHashSet<T> ptr)
            where T : unmanaged
            => @this.AsRefEnumerable(new SystemHashSetGeneric<T>.Ptr_SystemHashSetGeneric(ptr));
        public static IEnumerable<PMonoSlot<Ref_MonoSlot<T>, T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SystemHashSetGeneric<T>.Ptr_SystemHashSetGeneric ptr)
            where T : unmanaged
        {
            SystemHashSetGeneric<T>.LoadMetadata(@this, ptr);
            return ptr.AsRefEnumerable();

        }
        #endregion

        #region List<T>
        static SystemListGeneric<T>.Ptr_SystemListGeneric LoadSelf<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default)
            where T : unmanaged
        {
            return SystemListGeneric<T>.LoadSelf(runtimeContext.GetNotNullValue(), ptr.Ptr);
        }
        public static ReadOnlySpan<T> AsReadOnlySpan<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).AsReadOnlySpan();

        public static Span<T> AsSpan<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).AsSpan();

        public static IEnumerable<T> AsEnumerable<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default)where T : unmanaged
            => ptr.LoadSelf(runtimeContext).AsEnumerable();
        public static IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default)where T : unmanaged
            => ptr.LoadSelf(runtimeContext).AsRefEnumerable();

        public static int Count<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).GET_COUNT();
        public static void Clear<T>(this SysPtrList<T> ptr, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).CLEAR();
        public static void Add<T>(this SysPtrList<T> ptr,in T val, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).ADD(val);
        public static bool Remove<T>(this SysPtrList<T> ptr, in T val, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).REMOVE(val);
        public static bool Contains<T>(this SysPtrList<T> ptr, in T val, MonoRuntimeContext? runtimeContext = default) where T : unmanaged
            => ptr.LoadSelf(runtimeContext).CONTAINS(val);

        #endregion

        #region Queue<T>

        public static IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SysPtrQueue<T> ptr)
            where T : unmanaged
            => @this.AsRefEnumerable(new SystemQueueGeneric<T>.Ptr_SystemQueueGeneric(ptr));
        public static IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SystemQueueGeneric<T>.Ptr_SystemQueueGeneric ptr)
            where T : unmanaged
        {
            SystemQueueGeneric<T>.LoadMetadata(@this, ptr);
            return ptr.AsRefEnumerable();
        }
        #endregion

        #region Stack<T>

        public static IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SysPtrStack<T> ptr)
            where T : unmanaged
            => @this.AsRefEnumerable(new SystemStackGeneric<T>.Ptr_SystemStackGeneric(ptr));
        public static IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable<T>(this MonoRuntimeContext @this, SystemStackGeneric<T>.Ptr_SystemStackGeneric ptr)
            where T : unmanaged
        {
            SystemStackGeneric<T>.LoadMetadata(@this, ptr);
            return ptr.AsRefEnumerable();
        }
        #endregion

    }

}
