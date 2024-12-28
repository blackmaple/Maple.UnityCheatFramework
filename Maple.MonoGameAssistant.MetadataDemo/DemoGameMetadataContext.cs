using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    [ContextMetadataCtorAttribute(typeof(ContextMetadataCollector))]
    [ContextMetadata<DemoGameSystem>]
    public partial class DemoGameMetadataContext
    {
    }
}

