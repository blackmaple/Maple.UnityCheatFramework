using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public interface IClassMetadataCollector : IClassMetadataCollectorCode
    {
        abstract static ulong CODE { get; }
    }
}
