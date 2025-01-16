using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon
{
    public sealed class MetadataCollectorException(string? msg) : MonoCommonException(msg)
    {
        [DoesNotReturn]
        public static void Throw(string? msg) => throw new MetadataCollectorException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string? msg) => throw new MetadataCollectorException(msg);

    }
}
