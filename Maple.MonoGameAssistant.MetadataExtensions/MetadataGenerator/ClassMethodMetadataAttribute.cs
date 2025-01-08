#pragma warning disable IDE0060 // 删除未使用的参数

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

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
    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
