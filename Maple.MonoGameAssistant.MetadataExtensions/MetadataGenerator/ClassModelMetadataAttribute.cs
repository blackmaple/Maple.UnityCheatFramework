using System;
using System.Diagnostics;
#pragma warning disable IDE0060 // 删除未使用的参数

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
     class ClassModelMetadataAttribute : Attribute
    {

        public ClassModelMetadataAttribute(byte[] utf8ImageName, byte[]? utf8Namespace, byte[]? utf8ClassName, byte[]? utf8FullName = default) { }

        public ClassModelMetadataAttribute(string imageName, string? nameSpace, string? className, string? fullName = default) { }

    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
