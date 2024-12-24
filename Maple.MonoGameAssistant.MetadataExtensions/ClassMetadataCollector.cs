using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ClassMetadataCollector(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection) : IClassMetadataCollectorCode
    {
        public ContextMetadataCollector MetadataCollector { get; } = metadataCollector;
        public ILogger Logger => MetadataCollector.Logger;
        public MetadataCollectorSearchService SearchService => MetadataCollector.SearchService;
        public MonoRuntimeContext RuntimeContext => MetadataCollector.RuntimeContext;
        public MonoClassMetadataCollection Collection { get; } = collection;

    }
}
