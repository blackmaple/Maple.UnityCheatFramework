﻿using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ClassMetadataCollector(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection) : IClassMetadataCollectorCode
    {
        public ContextMetadataCollector MetadataCollector { get; } = metadataCollector;
        public ILogger Logger => MetadataCollector.Logger;
        public MetadataCollectorSearchService SearchService => MetadataCollector.SearchService;
        public MonoRuntimeContext RuntimeContext => MetadataCollector.RuntimeContext;
        public MonoClassMetadataCollection MetadataCollection { get; } = collection;

        public bool TryGetMethodMetadata(MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            foreach (var method in this.MetadataCollection.MethodInfos)
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
        public bool TryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            pointer = this.RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            return pointer != nint.Zero;

        }
        public bool TryGetFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);
            IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs =
                descriptionFieldDTO.IsStatic
                ? this.MetadataCollection.EnumStaticFieldInfos()
                : this.MetadataCollection.EnumMemberFieldInfos();
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

        public MonoStaticMethodDelegate GetStaticMethodDelegate(long code)
        {
            if (false == this.SearchService.TrySearchMethod(code, out var descriptionMethodDTO))
            {
                return MetadataCollectorException.Throw<MonoStaticMethodDelegate>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            if (false == this.TryGetMethodMetadata(descriptionMethodDTO, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoStaticMethodDelegate>($"{nameof(TryGetMethodMetadata)}:{code}");
            }
            if (false == this.TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoStaticMethodDelegate>($"{nameof(TryGetMethodPointer)}:{code}");
            }
            return new(methodInfoDTO.Pointer, pointer);

        }
        public nint GetMethodPointer(long code)
        {
            MonoStaticMethodDelegate methodDelegate = GetStaticMethodDelegate(code);
            return methodDelegate.PtrMethod;
        }

        public MonoFieldInfoDTO GetFieldMetadata(long code)
        {
            if (false == this.SearchService.TrySearchField(code, out var descriptionFieldDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorSearchService.TrySearchField)}:{code}");
            }
            if (false == this.TryGetFieldMetadata(descriptionFieldDTO, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(TryGetFieldMetadata)}:{code}");
            }
            return fieldInfoDTO;
        }
        public int GetMemberFieldOffset(long code)
        {
            var fieldInfoDTO = this.GetFieldMetadata(code);
            return fieldInfoDTO.Offset;
        }
        public nint GetStaticInstancePointer(long code)
        {
            var fieldInfoDTO = this.GetFieldMetadata(code);
            return this.RuntimeContext.GetMonoStaticFieldValueAsPointer(fieldInfoDTO.SourceClass, fieldInfoDTO.Pointer);
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
}
