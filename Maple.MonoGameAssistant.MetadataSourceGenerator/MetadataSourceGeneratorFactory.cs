using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;

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
                var contextParentSymbols = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ContextParentMetadataAttribute<>).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return new ContextParentMetadataData()
                    {
                        ParentSymbol = ctx.Attributes[0].AttributeClass.TypeArguments[0],
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
                var combineSymbols = contextParentSymbols.Combine(contextClassSymbols.Collect());
                context.RegisterSourceOutput(combineSymbols, (context, combineData) =>
                {
                    var ctor = combineData.Left;
                    var props = combineData.Right;
                    foreach (var prop in props)
                    {
                        if (SymbolEqualityComparer.Default.Equals(prop.ContextSymbol, ctor.ContextSymbol))
                        {
                            var args = ctor.ParentSymbol.BuildParameterSyntaxExpression().ToArray();
                            var members = prop.BuildContextPropertiesExpression().ToArray();
                            var mainCtor = prop.BuildContextMetadataCtorExpression(args, members);
                            var classDeclaration = prop.BuildContextMetadataClassExpression(ctor.ParentSymbol, mainCtor, members);
                            var namespaceDeclaration = prop.BuildContextMetadataNamespaceExpression(classDeclaration);
                            context.AddSource($"{prop.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());
                        }
                    }

                });

                var classSymbols = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ClassMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return (ctx.Attributes, ctx.TargetSymbol);
                });
            }
            catch (MetadataSourceGeneratorException ex)
            {

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
}
