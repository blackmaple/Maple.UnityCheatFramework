using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Runtime.InteropServices;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassPropertyMetadataData
    {

        public IPropertySymbol PropertySymbol { set; get; } = default!;
        public byte[]? Utf8PropertyName { set; get; }
        public byte[]? Utf8PropertyType { set; get; }
        public ulong PropertyCode { set; get; }
        public string GetOffsetVariableName() => $"s_{nameof(FieldOffsetAttribute)}_{PropertySymbol.Name}";
    }

}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
