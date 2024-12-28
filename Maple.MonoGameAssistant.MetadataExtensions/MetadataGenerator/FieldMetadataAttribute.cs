using System;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
         class FieldMetadataAttribute(byte[]? utf8FiledName, byte[]? utf8FileType = default) : Attribute
    {
        public byte[]? Utf8FiledName { get; } = utf8FiledName;
        public byte[]? Utf8FieldType { get; set; } = utf8FileType;
    }


    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class StaticFieldMetadataAttribute(byte[]? utf8FiledName, byte[]? utf8FileType = default)
        : FieldMetadataAttribute(utf8FiledName, utf8FileType)
    {

    }

}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
