using System;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class MetadataSourceGeneratorException(string msg) : Exception(msg)
    {
        public static void Throw(string msg) => throw new MetadataSourceGeneratorException(msg);

        public static T Throw<T>(string msg) => throw new MetadataSourceGeneratorException(msg);

    }
}
