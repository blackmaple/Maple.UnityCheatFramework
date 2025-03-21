using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{
    public static class MetadataObjectExtensions
    {
        public static ConcurrentDictionary<PMonoClass, MonoClassMetadataCollection> MetadataObjectCache { get; } = [];

        public static bool TryGetClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (pMonoObject == nint.Zero)
            {
                return false;
            }
            var pMonoClass = @this.RuntiemProvider.GetMonoClass(pMonoObject);
            classMetadataCollection = @this.GetClassMetadata(pMonoClass);
            return true;
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject)
        {
            return @this.GetClassMetadata(@this.RuntiemProvider.GetMonoClass(pMonoObject));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, PMonoClass pMonoClass)
        {
            return MetadataObjectCache.GetOrAdd(pMonoClass, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoFieldInfoDTO fieldInfoDTO)
        {
            return MetadataObjectCache.GetOrAdd(fieldInfoDTO.FieldType.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoParameterTypeDTO parameterTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(parameterTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoReturnTypeDTO returnTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(returnTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

    }




    public class SysGenericList : AbstractClassMetadataCollector
    {
        protected static bool InitFieldMetadata { set; get; }

        static readonly MonoDescriptionFieldDTO s_Desc__ITEMS = new()
        {
            IsStatic = false,
            Utf8Name = [95, 105, 116, 101, 109, 115]//"_items"u8.ToArray()
        };
        public static int FiledItemsOffset { set; get; }
        static readonly MonoDescriptionFieldDTO s_Desc__SIZE = new()
        {
            IsStatic = false,
            Utf8Name = [95, 115, 105, 122, 101]//"_size"u8.ToArray()
        };
        public static int FiledSizeOffset { set; get; }


        protected virtual void LoadFieldMetadata()
        {
            if (InitFieldMetadata)
            {
                return;
            }
            if (!this.DefaultTryGetFieldMetadata(s_Desc__ITEMS, out var itemMetdata))
            {
                MetadataCollectorException.Throw($"{nameof(LoadFieldMetadata)}:{nameof(PtrList.ITEMS)}");
            }
            if (!this.DefaultTryGetFieldMetadata(s_Desc__SIZE, out var sizeMetadata))
            {
                MetadataCollectorException.Throw($"{nameof(LoadFieldMetadata)}:{nameof(PtrList.SIZE)}");
            }
            FiledItemsOffset = itemMetdata.Offset;
            FiledSizeOffset = sizeMetadata.Offset;
            InitFieldMetadata = true;
        }
        protected virtual void LoadMethodMetadata()
        {

        }

        public SysGenericList(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection) : base(contextMetadata, classMetadataCollection)
        {
            LoadFieldMetadata();
            LoadMethodMetadata();
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, PMonoObject pMonoObject) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(pMonoObject))
        {

        }
        public SysGenericList(ContextMetadataCollector contextMetadata, PMonoClass pMonoClass) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(pMonoClass))
        {

        }
        public SysGenericList(ContextMetadataCollector contextMetadata, MonoFieldInfoDTO fieldInfoDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(fieldInfoDTO))
        {

        }
        public SysGenericList(ContextMetadataCollector contextMetadata, MonoParameterTypeDTO parameterTypeDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(parameterTypeDTO))
        {

        }
        public SysGenericList(ContextMetadataCollector contextMetadata, MonoReturnTypeDTO returnTypeDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(returnTypeDTO))
        {

        }





    }

    public class SysGenericList<TITEM> : SysGenericList where TITEM : unmanaged
    {
        static FunctionPointerType_ADD_C51EC44DDD54EC33 s_FunctionPointerType_ADD_C51EC44DDD54EC33;
        static FunctionPointerType_CLEAR_F7EDAD10DE185E80 s_FunctionPointerType_CLEAR_F7EDAD10DE185E80;

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        unsafe readonly struct FunctionPointerType_ADD_C51EC44DDD54EC33(System.IntPtr pointer)
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, void> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, TITEM, void>)pointer;
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Delegate(System.IntPtr @this, TITEM item) => this.m_Pointer(@this, item);
            public static implicit operator FunctionPointerType_ADD_C51EC44DDD54EC33(System.IntPtr pointer) => new FunctionPointerType_ADD_C51EC44DDD54EC33(pointer);
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        unsafe readonly struct FunctionPointerType_CLEAR_F7EDAD10DE185E80(System.IntPtr pointer)
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, void> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, void>)pointer;
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Delegate(System.IntPtr @this) => this.m_Pointer(@this);
            public static implicit operator FunctionPointerType_CLEAR_F7EDAD10DE185E80(System.IntPtr pointer) => new FunctionPointerType_CLEAR_F7EDAD10DE185E80(pointer);
        }







        public SysGenericList(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection) : base(contextMetadata, classMetadataCollection)
        {
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, PMonoObject pMonoObject) : base(contextMetadata, pMonoObject)
        {
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, PMonoClass pMonoClass) : base(contextMetadata, pMonoClass)
        {
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, MonoFieldInfoDTO fieldInfoDTO) : base(contextMetadata, fieldInfoDTO)
        {
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, MonoParameterTypeDTO parameterTypeDTO) : base(contextMetadata, parameterTypeDTO)
        {
        }

        public SysGenericList(ContextMetadataCollector contextMetadata, MonoReturnTypeDTO returnTypeDTO) : base(contextMetadata, returnTypeDTO)
        {
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

    }

    partial struct PtrSysList<TITEM>
    {
        /// <summary>
        /// 0x10 T[] _items
        /// class ["mscorlib"."System.Collections.Generic"."T[]"]
        /// </summary>
        /// <returns>class T[]</returns>

        //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "T[]")]
        public PMonoArray<TITEM> ITEMS => ClassMetadataCollector.GetMemberFieldValue<PMonoArray<TITEM>>(this, SysGenericList<TITEM>.FiledItemsOffset);


        /// <summary>
        /// 0x18 System.Int32 _size
        /// struct ["mscorlib"."System"."Int32"]
        /// </summary>
        /// <returns>struct System.Int32</returns>

        //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
        public System.Int32 SIZE => ClassMetadataCollector.GetMemberFieldValue<int>(this, SysGenericList<TITEM>.FiledSizeOffset);


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

        public void ADD(TITEM item) => SysGenericList<TITEM>.s_FunctionPointerType_ADD_C51EC44DDD54EC33.Delegate(this, item);
        public void CLEAR() => SysGenericList < TITEM > s_FunctionPointerType_CLEAR_F7EDAD10DE185E80.Delegate(this);


        public ReadOnlySpan<TITEM> AsReadOnlySpan() => ITEMS.AsReadOnlySpan(SIZE);
        public Span<TITEM> AsSpan() => ITEMS.AsSpan(SIZE);

    }
}
