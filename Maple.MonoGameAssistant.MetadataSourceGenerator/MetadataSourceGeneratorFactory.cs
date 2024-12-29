using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    [Generator]
    public class MetadataSourceGeneratorFactory : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            try
            {
                // System.Diagnostics.Debugger.Launch();
                var contextCtorSymbols = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ContextCtorMetadataAttribute<>).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return new ContextCtorMetadataData()
                    {
                        CtorSymbol = ctx.Attributes[0].AttributeClass.TypeArguments[0],
                        ContextSymbol = ctx.TargetSymbol
                    };

                });



                var contextClassSymbols = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ContextPropertyMetadataAttribute<>).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return new ContextPropertyMetadataData()
                    {
                        ClassSymbols = [.. ctx.Attributes.SelectMany(p => p.AttributeClass.TypeArguments)],
                        ContextSymbol = ctx.TargetSymbol
                    };

                });
                var combineSymbols = contextCtorSymbols.Combine(contextClassSymbols.Collect());

                context.RegisterSourceOutput(combineSymbols, (context, combineData) =>
                {
                    var ctor = combineData.Left;
                    var props = combineData.Right;

                    foreach (var prop in props)
                    {
                        if (SymbolEqualityComparer.Default.Equals(prop.ContextSymbol, ctor.ContextSymbol))
                        {
                            //// 创建包含属性的类语法树
                            var classDeclaration = SyntaxFactory.ClassDeclaration(prop.ContextSymbol.Name)
                                .WithModifiers(SyntaxFactory.TokenList(
                                    [
                                        SyntaxFactory.Token(SyntaxKind.PartialKeyword)
                                    ]));
                                
                         

                            foreach (var klass in prop.ClassSymbols)
                            {
                                // 创建属性语法树
                                var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(klass.ToDisplayString()), klass.Name)
                                  .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                                  .WithAccessorList(SyntaxFactory.AccessorList([SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))]));

                                classDeclaration = classDeclaration.AddMembers(propertyDeclaration);
                            }

                            var namespaceDeclaration = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(prop.ContextSymbol.ContainingNamespace.ToDisplayString()))
                             .AddMembers(classDeclaration);
                            context.AddSource($"{prop.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());
                        }
                    }

                });

                var classSymbols = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ClassMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return (ctx.Attributes, ctx.TargetSymbol);
                });
            }
            catch (Exception ex)
            {
                //var diagnostic = Diagnostic.Create(
                //    new DiagnosticDescriptor(
                //        "HWG001",
                //        "源生成器异常",
                //        "源生成器执行时发生异常: {0}",
                //        "源生成器",
                //        DiagnosticSeverity.Error,
                //        isEnabledByDefault: true),
                //    Location.None,
                //    ex.ToString());

                //context.r(diagnostic);
            }

        }
    }

    public static class MetadataSourceGeneratorExtensions
    {
        static T GetAttributeValue_NamedArgs<T>(this AttributeData attributeData, string name, T def)
        {
            var nVal = attributeData.NamedArguments.FirstOrDefault(p => p.Key == name).Value;
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.Values is T arr)
                {
                    return arr;
                }
            }
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                return (T)nVal.Value;
            }
            else if (nVal.Value is T val2)
            {
                return val2;
            }
            return def;
        }
        static bool TryGetAttributeValue_CtorArgs<T>(this AttributeData attributeData, int index, out T val)
        {
            Unsafe.SkipInit(out val);
            var nVal = attributeData.ConstructorArguments.ElementAtOrDefault(index);
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.Values is T arr)
                {
                    val = arr;
                    return true;
                }
            }
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                val = (T)nVal.Value;
                return true;
            }
            else if (nVal.Value is T val2)
            {
                val = val2;
                return true;
            }

            return false;
        }

        static IEnumerable<T> ReadImmutableArray<T>(this ImmutableArray<TypedConstant> offsetSymbols)
            where T : struct
        {
            if (offsetSymbols.IsDefaultOrEmpty)
            {
                yield break;
            }
            foreach (var subMember in offsetSymbols)
            {
                if (subMember.Value is T val)
                {
                    yield return val;
                }
            }

        }

        static string ArrayDisplay<T>(this IEnumerable<T> arr)
            where T : struct
        {
            return $@"[{string.Join(", ", arr)}]";
        }


        //public static System.Collections.Generic.IEnumerable<SettingsMetadataData> EnumSettingsMetadataData()
        //{

        //}
    }

    public class ContextCtorMetadataData
    {
        public ISymbol CtorSymbol { set; get; }
        public ISymbol ContextSymbol { set; get; }
    }
    public class ContextPropertyMetadataData
    {
        public ISymbol ContextSymbol { set; get; }
        public ISymbol[] ClassSymbols { set; get; }
    }

    public class ClassMetadataData
    {
        public ISymbol ClassSymbol { set; get; }
        public ISymbol[] FieldSymbols { set; get; }
        public ISymbol[] MethodSymbols { set; get; }

    }

    public class MetadataSourceGeneratorException : Exception
    {

    }
}
