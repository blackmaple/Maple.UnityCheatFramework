using System;

namespace Maple.MonoGameAssistant.MetadataModel.MetadataAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ClassMetadataAttribute(byte[] utf8ImageName, byte[]? utf8Namespace, byte[]? utf8ClassName, byte[]? utf8FullName = default) : Attribute
    {
        public byte[] Utf8ImageName { get; } = utf8ImageName;
        public byte[]? Utf8Namespace { get; } = utf8Namespace;
        public byte[]? Utf8ClassName { get; } = utf8ClassName;
        public byte[]? Utf8FullName { get; } = utf8FullName;

    }
}
