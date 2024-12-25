using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;

namespace Maple.MonoGameAssistant.MetadataExtensions.Metadata
{
    public interface IClassMetadataCollector : MetadataModel.ClassMetadata.IClassMetadataCollector
    {
        abstract static ulong CODE { get; }
    }
}
