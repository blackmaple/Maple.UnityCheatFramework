using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class AbstractClassMetadataCollector(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : IAbstractClassMetadataCollector
    {
        public MonoClassMetadataCollection ClassMetadata { get; } = classMetadataCollection;
        public MonoRuntimeContext RuntimeContext => runtimeContext;

        protected bool DefaultTryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            return this.ClassMetadata.TryGetMethodMetadata(descriptionMethodDTO, out methodInfoDTO);
        }
        protected bool DefaultTryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            return RuntimeContext.TryGetMethodPointer(methodInfoDTO, out pointer);
        }
        protected bool DefaultTryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            return this.ClassMetadata.TryGetFieldMetadata(descriptionFieldDTO, out fieldInfoDTO);
        }


        protected virtual bool CustomTryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            return false;
        }
        protected virtual bool CustomTryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            Unsafe.SkipInit(out pointer);
            return false;
        }
        protected virtual bool CustomTryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);
            return false;

        }

        protected bool TryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            return CustomTryGetMethodMetadata(descriptionMethodDTO, out methodInfoDTO) || DefaultTryGetMethodMetadata(descriptionMethodDTO, out methodInfoDTO);
        }
        protected bool TryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            return CustomTryGetMethodPointer(methodInfoDTO, out pointer) || DefaultTryGetMethodPointer(methodInfoDTO, out pointer);
        }
        protected bool TryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            return CustomTryGetFieldMetadata(descriptionFieldDTO, out fieldInfoDTO) || DefaultTryGetFieldMetadata(descriptionFieldDTO, out fieldInfoDTO);
        }

        public MonoMethodDelegate GetMethodDelegate(MonoJsonMethodDTO descriptionMethodDTO)
        {
            if (false == TryGetMethodMetadata(descriptionMethodDTO, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(TryGetMethodMetadata)} ERROR");
            }
            if (false == TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(TryGetMethodPointer)} ERROR");
            }
            return new(methodInfoDTO.Pointer, pointer);
        }
        public MonoFieldInfoDTO GetFieldMetadata(MonoJsonFieldDTO descriptionFieldDTO)
        {
            if (false == TryGetFieldMetadata(descriptionFieldDTO, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(TryGetFieldMetadata)} ERROR");
            }
            return fieldInfoDTO;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T_FieldValue GetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource)
            where T_FieldValue : unmanaged
        {
            var context = MonoRuntimeContext.GlobalInstance;
            if (context is null)
            {
                return default;
            }
            return context.GetMonoStaticFieldValueAsUnmanaged<T_FieldValue>(staticFieldSource.SourceClass, staticFieldSource.RuntimeField);
        }

        [DoesNotReturn]
        public static void SetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            throw new NotImplementedException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset) where T_FieldValue : unmanaged
        {
            ref var ref_Buffer = ref @this.AsRefStruct<byte>();
            ref var ref_Member = ref Unsafe.Add(ref ref_Buffer, fieldOffset);
            ref var ref_Value = ref Unsafe.As<byte, T_FieldValue>(ref ref_Member);
            return ref ref_Value;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
            ref_Value = value;
        }

    }

    public abstract partial class ClassMetadataCollector(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(contextMetadata.RuntimeContext, classMetadataCollection), IClassMetadataCollector
    {

        public ContextMetadataCollector ContextMetadata { get; } = contextMetadata;
        public MetadataCollectorSearchService SearchService => ContextMetadata.SearchService;
        public ILogger Logger => ContextMetadata.Logger;

        public MonoMethodDelegate GetMethodDelegate(ulong code)
        {
            if (false == SearchService.TrySearchMethod(code, out var descriptionMethodDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            return GetMethodDelegate(descriptionMethodDTO);

        }
        public MonoMethodDelegate<TFUNC> GetMethodDelegate<TFUNC>(ulong code) where TFUNC : unmanaged
            => GetMethodDelegate(code);
        public nint GetMethodPointer(ulong code)
        {
            MonoMethodDelegate methodDelegate = GetMethodDelegate(code);
            return methodDelegate.MethodPointer;
        }


        public MonoFieldInfoDTO GetFieldMetadata(ulong code)
        {
            if (false == SearchService.TrySearchField(code, out var descriptionFieldDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorSearchService.TrySearchField)}:{code}");
            }
            return GetFieldMetadata(descriptionFieldDTO);
        }
        public MonoMemberFieldSource GetMemberFieldMetadata(ulong code)
        {
            var fieldInfoDTO = GetFieldMetadata(code);
            return new MonoMemberFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.Offset);
        }
        public MonoStaticFieldSource GetStaticFieldMetadata(ulong code)
        {
            var fieldInfoDTO = GetFieldMetadata(code);
            return new MonoStaticFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.SourceClass);
        }
        public int GetMemberFieldOffset(ulong code)
        {
            var fieldSource = GetFieldMetadata(code);
            return fieldSource.Offset;
        }


        public static bool TryGetMethodPointer<T_Method>(MonoMethodInfoDTO methodInfoDTO, out T_Method method) where T_Method : unmanaged
        {
            Unsafe.SkipInit(out method);
            var context = MonoRuntimeContext.GlobalInstance;
            if (context is null)
            {
                return false;
            }
            var pointer = context.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            var ok = pointer != nint.Zero;
            if (ok)
            {
                method = Unsafe.As<MonoMethodPointer, T_Method>(ref pointer);
            }
            return ok;
        }





    }

    public abstract partial class ClassMetadataCollector<T_RefMetadata, T_PtrMetadata>(ContextMetadataCollector metadataCollector, ulong code)
        : ClassMetadataCollector<T_PtrMetadata>(metadataCollector, code)
        , IRefMetadataCollector<T_RefMetadata>
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {
    }

    public abstract partial class ClassMetadataCollector<T_PtrMetadata>(ContextMetadataCollector metadataCollector, ulong code)
        : ClassMetadataCollector(metadataCollector, metadataCollector.GetClassMetadataCollection(code))
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {


    }
}
