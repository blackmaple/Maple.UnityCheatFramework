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
 class GenericClassModelMetadataAttribute : Attribute
    {
        public GenericClassModelMetadataAttribute() { }
    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
