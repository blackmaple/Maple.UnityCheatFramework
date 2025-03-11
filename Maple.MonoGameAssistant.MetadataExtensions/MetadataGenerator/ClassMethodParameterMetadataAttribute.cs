using System;
using System.Diagnostics;

#pragma warning disable IDE0060 // 删除未使用的参数
namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class ClassMethodParameterMetadataAttribute : Attribute
    {
        public ClassMethodParameterMetadataAttribute(byte[] utf8ParameterType, int order = 0) { }

        public ClassMethodParameterMetadataAttribute(string parameterType, int order = 0) { }

    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
