using Microsoft.CodeAnalysis;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassMemberMetadataData
    {
        public ulong Code { set; get; }

        public ISymbol ParentSymbol { set; get; } = default!;

        public byte[]? Utf8ImageName { set; get; }
        public byte[]? Utf8Namespace { set; get; }
        public byte[]? Utf8ClassName { set; get; }
        public byte[]? Utf8FullName { set; get; }

        public ISymbol ContextSymbol { set; get; } = default!;
        public ISymbol PtrSymbol { set; get; } = default!;

        public ClassPropertyMetadataData[] PropertyMetadataDatas { set; get; } = default!;
        public ClassMethodMetadataData[] MethodMetadataDatas { set; get; } = default!;

    }

}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
