using System;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{


    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
         class ClassMethodMetadataAttribute(byte[]? utf8EntryPoint, byte[]? utf8ReturnType) : Attribute
    {
        public byte[]? Utf8EntryPoint { get; } = utf8EntryPoint;
        public byte[]? Utf8ReturnType { get; } = utf8ReturnType;

        public bool RuntimeMethodAsThis { set; get; } = false;
    }


}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
