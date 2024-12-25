using System;

namespace Maple.MonoGameAssistant.MetadataModel.MetadataAttribute
{


    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MethodMetadataAttribute(byte[] utf8EntryPoint, byte[]? utf8ReturnType) : Attribute
    {
        public byte[] Utf8EntryPoint { get; } = utf8EntryPoint;
        public byte[]? Utf8ReturnType { get; } = utf8ReturnType;

        public bool RuntimeMethodAsThis { set; get; } = false;
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class MethodParameterMetadataAttribute(byte[] utf8ParameterType, int order = 0) : Attribute
    {
        public byte[]? Utf8ParameterType { get; } = utf8ParameterType;
        public int Order { get; } = order;
    }


}
