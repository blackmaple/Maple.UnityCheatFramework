using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class ClassMetadataCollector : IClassMetadataCollector
    {
        public ContextMetadataCollector ContextMetadata { get; }
        public ILogger Logger => ContextMetadata.Logger;
        public MetadataCollectorSearchService SearchService => ContextMetadata.SearchService;
        public MonoRuntimeContext RuntimeContext => ContextMetadata.RuntimeContext;
        public MonoClassMetadataCollection ClassMetadata { get; }

        public ClassMetadataCollector(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection)
        {
            ContextMetadata = contextMetadata;
            ClassMetadata = classMetadataCollection;
            this.InitClassMetadata();
        }


        protected virtual void InitClassMetadata() { }


        public virtual bool CustomTryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            return false;
        }
        public bool DefaultTryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            foreach (var method in ClassMetadata.MethodInfos)
            {
                if (method.EqualMethodName(descriptionMethodDTO)
                    && method.EqualMethodReturnType(descriptionMethodDTO)
                    && method.EqualMethodParameterTypes(descriptionMethodDTO))
                {
                    methodInfoDTO = method;
                    return true;
                }
            }
            return false;

        }
        public bool TryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            return CustomTryGetMethodMetadata(descriptionMethodDTO, out methodInfoDTO) || DefaultTryGetMethodMetadata(descriptionMethodDTO, out methodInfoDTO);
        }

        public bool DefaultTryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            pointer = RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            return pointer != nint.Zero;

        }
        public virtual bool CustomTryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            Unsafe.SkipInit(out pointer);
            return false;
        }
        public bool TryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            return CustomTryGetMethodPointer(methodInfoDTO, out pointer) || DefaultTryGetMethodPointer(methodInfoDTO, out pointer);
        }


        public bool DefaultTryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);
            IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs =
                descriptionFieldDTO.IsStatic
                ? ClassMetadata.EnumStaticFieldInfos()
                : ClassMetadata.EnumMemberFieldInfos();
            foreach (var field in fieldInfoDTOs)
            {
                if (field.EqualFieldName(descriptionFieldDTO)
                    && field.EqualFieldType(descriptionFieldDTO))
                {
                    fieldInfoDTO = field;
                    return true;
                }
            }
            return false;
        }
        public virtual bool CustomTryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);
            return false;

        }
        public bool TryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            return CustomTryGetFieldMetadata(descriptionFieldDTO, out fieldInfoDTO) || DefaultTryGetFieldMetadata(descriptionFieldDTO, out fieldInfoDTO);
        }

        public MonoMethodDelegate GetMethodDelegate(ulong code)
        {
            if (false == SearchService.TrySearchMethod(code, out var descriptionMethodDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            if (false == TryGetMethodMetadata(descriptionMethodDTO, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(TryGetMethodMetadata)}:{code}");
            }
            if (false == TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(TryGetMethodPointer)}:{code}");
            }
            return new(methodInfoDTO.Pointer, pointer);

        }
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
            if (false == TryGetFieldMetadata(descriptionFieldDTO, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(TryGetFieldMetadata)}:{code}");
            }
            return fieldInfoDTO;
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

        public nint GetStaticFieldValueAsPointer(ulong code)
        {
            var fieldSource = GetFieldMetadata(code);
            return RuntimeContext.GetMonoStaticFieldValueAsPointer(fieldSource.SourceClass, fieldSource.Pointer);
        }

        public static nint GetStaticFieldValueAsPointer(MonoStaticFieldSource staticFieldSource)
        {
            if (MonoRuntimeContext.GlobalInstance is null)
            {
                return default;
            }
            return MonoRuntimeContext.GlobalInstance.GetMonoStaticFieldValueAsPointer(staticFieldSource.SourceClass, staticFieldSource.RuntimeField);
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

    public abstract partial class ClassMetadataCollector<T_RefMetadata, T_PtrMetadata>(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection)
        : ClassMetadataCollector<T_PtrMetadata>(metadataCollector, collection)
        , IRefMetadataCollector<T_RefMetadata>
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {
    }

    public abstract partial class ClassMetadataCollector<T_PtrMetadata>(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection)
        : ClassMetadataCollector(metadataCollector, collection)
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {


    }



}
