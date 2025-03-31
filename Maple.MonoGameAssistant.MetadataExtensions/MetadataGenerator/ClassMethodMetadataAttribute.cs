#pragma warning disable IDE0060 // 删除未使用的参数

using System.Diagnostics;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
    class ClassMethodMetadataAttribute : Attribute
    {
        public ClassMethodMetadataAttribute(byte[]? utf8EntryPoint, byte[]? utf8ReturnType = default)
        {

        }

        public ClassMethodMetadataAttribute(string? entryPoint, string? returnType = default)
        {

        }
        public bool RuntimeMethodAsThis { set; get; }
        public Type[]? CallConvs { set; get; }
        /// <summary>
        /// 区别重载函数 0参数 与 不匹配参数
        /// </summary>
        public bool VoidArgument { set; get; }
    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
