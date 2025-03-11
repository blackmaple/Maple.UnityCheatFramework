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
            //var path = context.AnalyzerConfigOptionsProvider.Select((p, _) =>
            //{
            //    if (p.GlobalOptions.TryGetValue("build_property.projectdir", out var path))
            //    {
            //        return path;
            //    }
            //    return default;
            //});

            var classMetadatas = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(ClassModelMetadataAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
            {
                return ctx.GetClassMemberMetadataData(ctx.Attributes[0]);

            });

            //classMetadatas = classMetadatas.Combine(path).Select((data, _) =>
            //{
            //    data.Left.ProjectPath = data.Right;
            //    return data.Left;
            //});

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
                context.AddSource($"{metadata.ContextSymbol.ToDisplayString()}.{metadata.Code:X8}.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());


                // MetadataSourceGeneratorJson.WriteJson2File(metadata);
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


            //context.RegisterPostInitializationOutput(ctx =>
            //{
            //    // 写入到文件
            //    var projectDirectory = ctx.AnalyzerConfigOptions.GlobalOptions["build_property.MSBuildProjectDirectory"];
            //    var filePath = Path.Combine(projectDirectory, "GeneratedData.json");
            //    File.WriteAllText(filePath, jsonString);

            //});




        }



    }


}
