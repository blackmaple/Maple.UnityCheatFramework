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

                InitializeClassPropertyMetadataAttribute(context);

                InitializeContextPropertyMetadataAttribute(context);

            }
            catch
            {

            }
        }

        public static void InitializeClassPropertyMetadataAttribute(IncrementalGeneratorInitializationContext context)
        {
            var classPropertyMetadatas = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ClassPropertyMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
            {

                var parentMetadata = ctx.TargetSymbol.GetAttributes().Where(p =>
                p.AttributeClass.ContainingNamespace.ToDisplayString() == typeof(ClassParentMetadataAttribute<>).Namespace
                && p.AttributeClass.MetadataName == typeof(ClassParentMetadataAttribute<>).Name
                ).FirstOrDefault();
                if (parentMetadata is null)
                {
                    return MetadataSourceGeneratorException.Throw<ClassPropertyMetadataData>($"{ctx.TargetSymbol.ToDisplayString()} not found {typeof(ClassParentMetadataAttribute<>).FullName}");
                }
                return new ClassPropertyMetadataData()
                {
                    ParentSymbol = parentMetadata.AttributeClass.TypeArguments[0],
                    ClassSymbol = ctx.TargetSymbol,
                    MetadataSymbol = ctx.Attributes[0].AttributeClass,
                };
            });

            context.RegisterSourceOutput(classPropertyMetadatas, (context, metdata) =>
            {


            });
        }

        public static void InitializeContextPropertyMetadataAttribute(IncrementalGeneratorInitializationContext context)
        {
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
                        var members = prop.BuildContextPropertiesExpression(ctor.ParentSymbol).ToArray();
                        var mainCtor = prop.BuildContextMetadataCtorExpression(args, members);
                        var classDeclaration = prop.BuildContextMetadataClassExpression(ctor.ParentSymbol, mainCtor, members);
                        var namespaceDeclaration = prop.BuildContextMetadataNamespaceExpression(classDeclaration);
                        context.AddSource($"{prop.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());
                    }
                }

            });

        }
    }


    public class ClassPropertyMetadataData
    {
        public ISymbol ParentSymbol { set; get; }
        public ISymbol MetadataSymbol { set; get; }

        public ISymbol ClassSymbol { set; get; }
        public ISymbol[] FieldSymbols { set; get; }
        public ISymbol[] MethodSymbols { set; get; }

    }
}
