using System;

namespace Maple.MonoGameAssistant.MetadataModel.MetadataAttribute
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FieldMetadataAttribute(byte[]? utf8FiledName, byte[]? utf8FileType = default) : Attribute
    {
        public byte[]? Utf8FiledName { get; } = utf8FiledName;
        public byte[]? Utf8FieldType { get; set; } = utf8FileType;
    }


    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class StaticFieldMetadataAttribute(byte[]? utf8FiledName, byte[]? utf8FileType = default)
        : FieldMetadataAttribute(utf8FiledName, utf8FileType)
    {

    }

}
