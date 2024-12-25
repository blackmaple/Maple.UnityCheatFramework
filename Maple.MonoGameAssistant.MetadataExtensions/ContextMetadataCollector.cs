using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public bool TryGetImageMetadata(MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            foreach (var data in this.ImageNames)
            {
                if (data.EqualImageName(descriptionClassDTO))
                {
                    imageNameDTO = data;
                    return true;
                }
            }
            return false;
        }
        public bool TryGetClassMetadata(MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            return this.RuntimeContext.TryGetFirstClassInfo(imageNameDTO, descriptionClassDTO, out classMetadataCollection);
        }
        public MonoClassMetadataCollection GetClassMetadataCollection(long code)
        {
            if (false == this.SearchService.TrySearchClass(code, out var descriptionClassDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            if (false == this.TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetImageMetadata)}:{code}");
            }
            if (false == this.TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetClassMetadata)}:{code}");
            }
            return classMetadataCollection;
        }


    }
}
