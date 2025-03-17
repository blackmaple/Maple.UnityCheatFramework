using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            classMetadataCollection = @this.GetClassMetadataImp(pMonoClass);
            return true;
        }

        private static MonoClassMetadataCollection GetClassMetadataImp(this MonoRuntimeContext @this, PMonoClass pMonoClass)
        {
            return MetadataObjectCache.GetOrAdd(pMonoClass, klass => @this.GetMonoClassMetadataCollection(klass));
        }



    }

    public struct ReflectionObject(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection metadataCollection)
    {
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoClassMetadataCollection MetadataCollection { get; } = metadataCollection;

        public bool TryGetFieldValue<T_VALUE>(Predicate predicate, out T_VALUE val) where T_VALUE : unmanaged
        {
            this.MetadataCollection.FieldInfos
        }
    }

}
