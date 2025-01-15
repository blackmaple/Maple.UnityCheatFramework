using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<MetadataModel.Game>]
    //[ContextMemberMetadata<ItemSystem>]


    public partial class EsportsMetadataContext
    {
        //public DemoGameMetadataContext()
        //{
        //    //this.DemoGameSystem = new DemoGameSystem();
        //}

        //    public sealed override string ApiVersion => throw new NotImplementedException();

    }

}

