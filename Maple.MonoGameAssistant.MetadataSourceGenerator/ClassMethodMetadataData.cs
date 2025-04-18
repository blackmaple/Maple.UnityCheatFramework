﻿using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Reflection;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassMethodMetadataData
    {
        public ulong Code { set; get; }
        public IMethodSymbol MethodSymbol { set; get; } = default!;
        public byte[]? Utf8MethodName { set; get; }
        public byte[]? Utf8MethodReturnType { set; get; }
        public byte[]?[]? Utf8MethodParameterTypes { set; get; }

        public ISymbol[]? CallConvs { set; get; }
        public bool RuntimeMethod { set; get; }

        public string GetDelegatePointerStructCtorArgName() => $"{nameof(Pointer).ToLower()}";
        public string GetDelegatePointerStructMemberName() => $"m_{nameof(Pointer)}";
        public string GetDelegatePointerStructCaller() => nameof(Delegate);

        public string GetDelegatePointerStructName() => $"{nameof(SymbolKind.FunctionPointerType)}_{MethodSymbol.Name}_{Code:X8}";
        public string GetDelegatePointerStaticFieldName() => $"s_{nameof(SymbolKind.FunctionPointerType)}_{MethodSymbol.Name}_{Code:X8}";

        public string GetDelegatePointerDescName() => $"s_{nameof(SymbolKind.Parameter)}_{MethodSymbol.Name}_{Code:X8}";

        public string GetConstCodeName() => $"{nameof(Code)}_{nameof(SymbolKind.FunctionPointerType)}_{MethodSymbol.Name}_{Code:X8}";

        //internal MonoJsonMethodDTO GetMonoJsonMethodDTO() => new(this.Code, this.Utf8MethodName, this.Utf8MethodParameterTypes, this.Utf8MethodReturnType);
    }

}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
