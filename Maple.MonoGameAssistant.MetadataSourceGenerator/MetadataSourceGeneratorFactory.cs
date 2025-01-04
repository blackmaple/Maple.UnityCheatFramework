using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    [Generator]
    public class MetadataSourceGeneratorFactory : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            try
            {
                Test();
                InitializeClassMetadata(context);

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

                metadata.BuildClassMetadataJson(fields);
                metadata.BuildClassPartialPropertyExpression(fields, expressions, structs);
                metadata.BuildClassPartialMethodExpression(structs, fields, expressions);

                var parameterSymbols = MetadataSourceGeneratorExtensions.GetCtorParameterSymbolExpression(metadata.ParentSymbol).ToArray();
                var parentCtorArgs = MetadataSourceGeneratorExtensions.BuildClassParentCtorParameterExpression(parameterSymbols, metadata.Code).ToArray();

                var mainCtor = MetadataSourceGeneratorExtensions.BuildDerivedCtorMethodExpression(metadata.ContextSymbol, parentCtorArgs, expressions);
                var classDeclaration = MetadataSourceGeneratorExtensions.CreateClassDeclarationSyntaxExpression(metadata.ContextSymbol, metadata.ParentSymbol, [.. fields, mainCtor, .. structs,]);
                var namespaceDeclaration = MetadataSourceGeneratorExtensions.BuildNamespaceExpression(metadata.ContextSymbol, classDeclaration);
                context.AddSource($"{metadata.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());
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



        public static void Test()
        {

            var typeName = SyntaxFactory.ParseTypeName("x123");
            var name = "x";


            var t =
                SyntaxFactory.PropertyDeclaration(typeName, name)
                .WithModifiers([
                    SyntaxFactory.Token( SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword)
                ])
                .WithAccessorList(
                    SyntaxFactory.AccessorList([
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration )
                        .WithSemicolonToken(SyntaxFactory.Token( SyntaxKind.SemicolonToken)),
                        SyntaxFactory.AccessorDeclaration( SyntaxKind.SetAccessorDeclaration)
                        .WithSemicolonToken(SyntaxFactory.Token( SyntaxKind.SemicolonToken)),
                    ])
                );

            //var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.IdentifierName("int"), "xxx")
            //    .WithLeadingTrivia(BuildSummaryComment(["123", "123", "123", default!]));



            //static SyntaxTriviaList BuildSummaryComment(params string?[] summaryTexts)
            //{
            //    var summaryComment = SyntaxFactory.TriviaList(
            //    SyntaxFactory.Trivia(
            //        SyntaxFactory.DocumentationCommentTrivia(
            //            SyntaxKind.MultiLineDocumentationCommentTrivia,
            //            [
            //                SyntaxFactory.XmlNewLine(""),
            //            SyntaxFactory.XmlMultiLineElement(
            //                SyntaxFactory.XmlName("summary"),
            //                [
            //                    ..EnumXmlTextSyntax(summaryTexts)
            //                ]),
            //            SyntaxFactory.XmlText("\r\n"),
            //            ]
            //    )));

            //    static IEnumerable<XmlTextSyntax> EnumXmlTextSyntax(params string?[] summaryTexts)
            //    {
            //        foreach (var summaryText in summaryTexts)
            //        {
            //            yield return SyntaxFactory.XmlNewLine("\r\n");
            //            yield return SyntaxFactory.XmlText(summaryText ?? string.Empty);

            //        }
            //        yield return SyntaxFactory.XmlNewLine("\r\n");
            //    }
            //    return summaryComment;
            //}



        }



    }


}
