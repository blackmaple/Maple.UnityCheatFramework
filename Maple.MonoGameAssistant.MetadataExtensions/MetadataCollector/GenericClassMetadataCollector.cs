using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class GenericClassMetadataCollector<T_Self, T_PtrMetadata>(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(runtimeContext, classMetadataCollection), IPtrMetadataCollector<T_PtrMetadata>
        where T_PtrMetadata : unmanaged, IPtrMetadata
        where T_Self : GenericClassMetadataCollector<T_Self, T_PtrMetadata>
    {

        #region Static
        protected static T_Self? Self { get; set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static T_Self LoadMetadata(PMonoObject pMonoObject, Func<MonoRuntimeContext, MonoClassMetadataCollection, T_Self> func)
        {
            if (Self is not null)
            {
                return Self;
            }
            if (!TryLoadMetadata(pMonoObject, out var runtimeContext, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<T_Self>($"{nameof(TryLoadMetadata)}:{typeof(T_Self).FullName} ERROR");
            }
            Self = func(runtimeContext, classMetadataCollection);
            return Self;
        }

        public static bool TryLoadMetadata(PMonoObject pMonoObject,
            [MaybeNullWhen(false)] out MonoRuntimeContext runtimeContext,
            [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            runtimeContext = MonoRuntimeContext.GlobalInstance;
            return runtimeContext is not null && runtimeContext.TryGetClassMetadata(pMonoObject, out classMetadataCollection);
        }
        #endregion


    }
}
