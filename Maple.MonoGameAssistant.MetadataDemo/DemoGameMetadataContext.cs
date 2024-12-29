using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    [ContextCtorMetadata<ContextMetadataCollector>()]
    [ContextPropertyMetadata<DemoGameSystem>]
    public partial class DemoGameMetadataContext
    {
        //public DemoGameMetadataContext()
        //{
        //    //this.DemoGameSystem = new DemoGameSystem();
        //}
    }
}

