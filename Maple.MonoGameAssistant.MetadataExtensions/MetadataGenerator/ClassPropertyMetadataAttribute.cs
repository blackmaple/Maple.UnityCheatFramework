using System;
using System.Diagnostics;
#pragma warning disable IDE0060 // 删除未使用的参数

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
         class ClassPropertyMetadataAttribute : Attribute
    {
        public ClassPropertyMetadataAttribute(byte[]? utf8FieldName, byte[]? utf8FieldType = default)
        {

        }
        public ClassPropertyMetadataAttribute(string? fieldName, string? fieldType = default)
        {

        }

    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
