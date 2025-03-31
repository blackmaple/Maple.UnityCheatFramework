using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    [Generator]
    public class MetadataSourceGeneratorFactory : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            try
            {

                InitializeClassMetadata(context);
                InitializeGenericClassModelMetadata(context);
                InitializeContextMetadata(context);

            }
            catch
            {

            }
        }

        public static void InitializeClassMetadata(IncrementalGeneratorInitializationContext context)
        {

            var classMetadatas = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ClassModelMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
            {
                return ctx.GetClassMemberMetadataData(ctx.Attributes[0]);

            });


            context.RegisterSourceOutput(classMetadatas, (context, metadata) =>
            {
                List<MemberDeclarationSyntax> fields = [];
                List<ExpressionStatementSyntax> expressions = [];
                List<StructDeclarationSyntax> structs = [];

                metadata.BuildClassCodeField(fields);
                metadata.BuildClassMetadataJson(fields);
                metadata.BuildClassPartialPropertyExpression(fields, expressions, structs);
                metadata.BuildClassPartialMethodExpression(structs, fields, expressions);

                var parameterSymbols = MetadataSourceGeneratorExtensions.GetCtorParameterSymbolExpression(metadata.ParentSymbol).ToArray();
                var parentCtorArgs = MetadataSourceGeneratorExtensions.BuildClassParentCtorParameterExpression(parameterSymbols, metadata.Code).ToArray();

                var mainCtor = MetadataSourceGeneratorExtensions.BuildDerivedCtorMethodExpression(metadata.ContextSymbol, parentCtorArgs, expressions);
                var classDeclaration = MetadataSourceGeneratorExtensions.CreateClassDeclarationSyntaxExpression(metadata.ContextSymbol, metadata.ParentSymbol, [.. fields, mainCtor, .. structs,]);
                var namespaceDeclaration = MetadataSourceGeneratorExtensions.BuildNamespaceExpression(metadata.ContextSymbol, classDeclaration);
                context.AddSource($"{metadata.ContextSymbol.ToDisplayString()}.{metadata.Code:X8}.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());


            });
        }
        public static void InitializeGenericClassModelMetadata(IncrementalGeneratorInitializationContext context)
        {

            var classMetadatas = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(GenericClassModelMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax klass && klass.TypeParameterList is not null, (ctx, _) =>
            {
                return ctx.GetGenericClassMemberMetadataData(ctx.Attributes[0]);

            });
            context.RegisterSourceOutput(classMetadatas, (context, metadata) =>
            {

                List<MemberDeclarationSyntax> fields = [];
                List<ExpressionStatementSyntax> expressions = [];
                List<StructDeclarationSyntax> structs = [];

                metadata.BuildClassCodeField(fields);
                metadata.BuildGenericClassMetadataJson(fields);
                metadata.BuildGenericClassPartialPropertyExpression(fields, expressions, structs);
                metadata.BuildGenericClassPartialMethodExpression(structs, fields, expressions);


                var parameterSymbols = MetadataSourceGeneratorExtensions.GetCtorParameterSymbolExpression(metadata.ParentSymbol).ToArray();
                var parentCtorArgs = MetadataSourceGeneratorExtensions.BuildGenericClassParentCtorParameterExpression(parameterSymbols).ToArray();
                var mainCtor = MetadataSourceGeneratorExtensions.BuildDerivedCtorMethodExpression(metadata.ContextSymbol, parentCtorArgs, expressions);
                // var loadmetadata = MetadataSourceGeneratorExtensions.BuildDerivedLoadMetadata(metadata );


                var classDeclaration = MetadataSourceGeneratorExtensions.CreateGenericClassDeclarationSyntaxExpression(metadata, [.. fields, mainCtor, .. structs]);

                var namespaceDeclaration = MetadataSourceGeneratorExtensions.BuildNamespaceExpression(metadata.ContextSymbol, classDeclaration);
                context.AddSource($"{metadata.ContextSymbol.ContainingNamespace.ToDisplayString()}.{metadata.ContextSymbol.Name}.{metadata.Code:X8}.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());

            });


        }

        public static void InitializeContextMetadata(IncrementalGeneratorInitializationContext context)
        {
            var contextMetadatas = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ContextParentMetadataAttribute<>).FullName,
                (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
            {
                return MetadataSourceGeneratorExtensions.GetContextMemberMetadataData(ctx, ctx.Attributes[0]);
            });


            context.RegisterSourceOutput(contextMetadatas, (context, metadata) =>
            {
                List<MemberDeclarationSyntax> fields = [];

                metadata.BuildContextJson(fields);


                var args = MetadataSourceGeneratorExtensions.BuildCtorParameterSyntaxExpression(metadata.ParentSymbol).ToArray();
                var members = metadata.BuildContextPropertiesExpression().ToArray();
                var assignmentMemeberExpression = members.BuildAssignmentMemeberExpression().ToArray();
                var mainCtor = MetadataSourceGeneratorExtensions.BuildDerivedCtorMethodExpression(metadata.ContextSymbol, args, assignmentMemeberExpression);
                var classDeclaration = MetadataSourceGeneratorExtensions.CreateClassDeclarationSyntaxExpression(metadata.ContextSymbol, metadata.ParentSymbol, [.. fields, .. members, mainCtor]);
                var namespaceDeclaration = MetadataSourceGeneratorExtensions.BuildNamespaceExpression(metadata.ContextSymbol, classDeclaration);
                context.AddSource($"{metadata.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());

            });

        }







    }


}
