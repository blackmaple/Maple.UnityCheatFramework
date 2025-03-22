using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{
    public class SysGenericList<TITEM> where TITEM : unmanaged
    {
        private static SysGenericList<TITEM>? GenericList { get; set; }


        static readonly MonoDescriptionFieldDTO s_Desc__ITEMS = new()
        {
            IsStatic = false,
            Utf8Name = [95, 105, 116, 101, 109, 115]//"_items"u8.ToArray()
        };
        public required int FiledItemsOffset { get; init; }

        static readonly MonoDescriptionFieldDTO s_Desc__SIZE = new()
        {
            IsStatic = false,
            Utf8Name = [95, 115, 105, 122, 101]//"_size"u8.ToArray()
        };
        public required int FiledSizeOffset { get; init; }


        static readonly MonoDescriptionMethodDTO s_Desc__ADD = new()
        {
            Utf8Name = [65, 100, 100],//"Add"u8.ToArray()
            Utf8ReturnType = [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100],//"System.Void"u8
        };
        public required FunctionPointerType_ADD FunctionPointer_ADD { get; init; }

        static readonly MonoDescriptionMethodDTO s_Desc__CLEAR = new()
        {
            Utf8Name = [67, 108, 101, 97, 114],//"Clear"u8.ToArray()
            Utf8ReturnType = [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100],//"System.Void"u8
        };
        public required FunctionPointerType_CLEAR FunctionPointer_CLEAR { get; init; }

        static readonly MonoDescriptionMethodDTO s_Desc__REMOVE = new()
        {
            Utf8Name = [82, 101, 109, 111, 118, 101],//"Remove"u8.ToArray()
            Utf8ReturnType = [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110],//"System.Boolean"u8
        };
        public required FunctionPointerType_REMOVE FunctionPointer_REMOVE { get; init; }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly struct FunctionPointerType_ADD(System.IntPtr pointer)
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, void> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, void>)pointer;
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Delegate(System.IntPtr @this, TITEM item) => this.m_Pointer(@this, item);
            public static implicit operator FunctionPointerType_ADD(System.IntPtr pointer) => new FunctionPointerType_ADD(pointer);
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly struct FunctionPointerType_CLEAR(System.IntPtr pointer)
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, void> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, void>)pointer;
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Delegate(System.IntPtr @this) => this.m_Pointer(@this);
            public static implicit operator FunctionPointerType_CLEAR(System.IntPtr pointer) => new FunctionPointerType_CLEAR(pointer);
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly struct FunctionPointerType_REMOVE(System.IntPtr pointer)
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, bool> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, bool>)pointer;
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Delegate(System.IntPtr @this, TITEM item) => this.m_Pointer(@this, item);
            public static implicit operator FunctionPointerType_REMOVE(System.IntPtr pointer) => new FunctionPointerType_REMOVE(pointer);
        }

        public static SysGenericList<TITEM> LoadMetadata(PMonoObject pMonoObject)
        {
            if (GenericList is not null)
            {
                return GenericList;
            }
            var context = MonoRuntimeContext.GlobalInstance;
            if (context is null)
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(MonoRuntimeContext)}:{nameof(MonoRuntimeContext.GlobalInstance)} NULL");
            }
            if (!context.TryGetClassMetadata(pMonoObject, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(MetadataObjectExtensions.TryGetClassMetadata)} ERROR");
            }
            if (!classMetadataCollection.TryGetFieldMetadata(s_Desc__ITEMS, out var itemsMetadata))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(PtrSysList<>.ITEMS)} ERROR");
            }
            if (!classMetadataCollection.TryGetFieldMetadata(s_Desc__SIZE, out var sizeMetadata))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(PtrSysList<>.SIZE)} ERROR");
            }
            if (!classMetadataCollection.TryGetMethodMetadata(s_Desc__ADD, out var addMetadata) || !context.TryGetMethodPointer(addMetadata, out var addPointer))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(PtrSysList<>.ADD)} ERROR");
            }
            if (!classMetadataCollection.TryGetMethodMetadata(s_Desc__CLEAR, out var clearMetadata) || !context.TryGetMethodPointer(addMetadata, out var clearPointer))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(PtrSysList<>.CLEAR)} ERROR");
            }
            if (!classMetadataCollection.TryGetMethodMetadata(s_Desc__REMOVE, out var removeMetadata) || !context.TryGetMethodPointer(removeMetadata, out var removePointer))
            {
                return MetadataCollectorException.Throw<SysGenericList<TITEM>>($"{nameof(LoadMetadata)}.{nameof(PtrSysList<>.REMOVE)} ERROR");
            }
            return GenericList = new SysGenericList<TITEM>()
            {
                FiledItemsOffset = itemsMetadata.Offset,
                FiledSizeOffset = sizeMetadata.Offset,
                FunctionPointer_ADD = addPointer,
                FunctionPointer_CLEAR = clearPointer,
                FunctionPointer_REMOVE = removePointer,
            };


        }



    }


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe readonly partial struct PtrSysList<TITEM>(System.IntPtr ptr) : IPtrMetadata
        where TITEM : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly System.IntPtr m_Pointer = ptr;
        public System.IntPtr Ptr => m_Pointer;

        public static implicit operator PtrSysList<TITEM>(System.IntPtr ptr) => new(ptr);
        public static implicit operator System.IntPtr(PtrSysList<TITEM> ptr) => ptr.m_Pointer;
        public static implicit operator bool(PtrSysList<TITEM> ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        public static implicit operator PMonoObject(PtrSysList<TITEM> ptr) => ptr.m_Pointer;

    }

    partial struct PtrSysList<TITEM>
    {
        /// <summary>
        /// 0x10 T[] _items
        /// class ["mscorlib"."System.Collections.Generic"."T[]"]
        /// </summary>
        /// <returns>class T[]</returns>

        //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "T[]")]
        public PMonoArray<TITEM> ITEMS => ClassMetadataCollector.GetMemberFieldValue<PMonoArray<TITEM>>(this, SysGenericList<TITEM>.LoadMetadata(this).FiledItemsOffset);


        /// <summary>
        /// 0x18 System.Int32 _size
        /// struct ["mscorlib"."System"."Int32"]
        /// </summary>
        /// <returns>struct System.Int32</returns>

        //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
        public System.Int32 SIZE => ClassMetadataCollector.GetMemberFieldValue<int>(this, SysGenericList<TITEM>.LoadMetadata(this).FiledSizeOffset);


        /// <summary>
        /// 0x1C System.Int32 _version
        /// struct ["mscorlib"."System"."Int32"]
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /*
       [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
       public partial System.Int32 _VERSION { get; set; } 
*/

        /// <summary>
        /// 0x20 System.Object _syncRoot
        /// class ["mscorlib"."System"."Object"]
        /// </summary>
        /// <returns>class System.Object</returns>
        /*
       [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
       public partial nint _SYNC_ROOT { get; set; } 
*/

        public void ADD(TITEM item) => SysGenericList<TITEM>.LoadMetadata(this).FunctionPointer_ADD.Delegate(this, item);

        public void CLEAR() => SysGenericList<TITEM>.LoadMetadata(this).FunctionPointer_CLEAR.Delegate(this);

        public void REMOVE(TITEM item) => SysGenericList<TITEM>.LoadMetadata(this).FunctionPointer_REMOVE.Delegate(this, item);

        public ReadOnlySpan<TITEM> AsReadOnlySpan() => ITEMS.AsReadOnlySpan(SIZE);
        public Span<TITEM> AsSpan() => ITEMS.AsSpan(SIZE);
        public TITEM[] ToArray() => AsSpan().ToArray();
        public IEnumerable<TITEM> AsEnumerable()
        {
            PMonoArray<TITEM> items = ITEMS;
            var count = SIZE;
            for (int i = 0; i < count; ++i)
            {
                yield return items.AsReadOnlySpan(count)[i % count];
            }
        }



    }
}
