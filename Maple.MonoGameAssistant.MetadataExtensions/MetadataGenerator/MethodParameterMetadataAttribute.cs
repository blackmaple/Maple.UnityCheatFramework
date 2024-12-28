using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class MethodParameterMetadataAttribute(byte[] utf8ParameterType, int order = 0) : Attribute
    {
        public byte[] Utf8ParameterType { get; } = utf8ParameterType;
        public int Order { get; } = order;
    }


}
