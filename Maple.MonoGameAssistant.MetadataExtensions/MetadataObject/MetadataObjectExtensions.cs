﻿using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{
    public static class MetadataObjectExtensions
    {
        public static ConcurrentDictionary<PMonoClass, MonoClassMetadataCollection> MetadataObjectCache { get; } = [];

        public static MonoClassMetadataCollection GetOrAddClassMetadata(this MonoRuntimeContext @this, PMonoClass pMonoClass)
        {
            return MetadataObjectCache.GetOrAdd(pMonoClass, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static bool TryGetOrAddClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (pMonoObject == nint.Zero)
            {
                return false;
            }
            var pMonoClass = @this.RuntiemProvider.GetMonoClass(pMonoObject);
            classMetadataCollection = @this.GetOrAddClassMetadata(pMonoClass);
            return true;
        }

        public static MonoClassMetadataCollection GetOrAddClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject)
        {
            return @this.GetOrAddClassMetadata(@this.RuntiemProvider.GetMonoClass(pMonoObject));
        }

        public static MonoClassMetadataCollection GetOrAddClassMetadata(this MonoRuntimeContext @this, MonoFieldInfoDTO fieldInfoDTO)
        {
            return MetadataObjectCache.GetOrAdd(fieldInfoDTO.FieldType.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetOrAddClassMetadata(this MonoRuntimeContext @this, MonoParameterTypeDTO parameterTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(parameterTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetOrAddClassMetadata(this MonoRuntimeContext @this, MonoReturnTypeDTO returnTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(returnTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

    }


}
