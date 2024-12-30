using System;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
     class ClassModelMetadataAttribute(byte[] utf8ImageName, byte[]? utf8Namespace, byte[]? utf8ClassName, byte[]? utf8FullName = default) : Attribute
    {
        public byte[] Utf8ImageName { get; } = utf8ImageName;
        public byte[]? Utf8Namespace { get; } = utf8Namespace;
        public byte[]? Utf8ClassName { get; } = utf8ClassName;
        public byte[]? Utf8FullName { get; } = utf8FullName;

    }
}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
