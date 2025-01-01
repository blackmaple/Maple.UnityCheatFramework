﻿using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Immutable;
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
                List<FieldDeclarationSyntax> fields = [];
                List<ExpressionStatementSyntax> expressions = [];
                List<StructDeclarationSyntax> structs = [];

                metadata.BuildClassPartialPropertyExpression(fields, expressions, structs);


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
                var parentMetadata = ctx.TargetSymbol.GetAttributes().Where(p =>
                    p.AttributeClass!.ContainingNamespace.ToDisplayString() == typeof(ContextMemberMetadataAttribute<>).Namespace
                    && p.AttributeClass.MetadataName == typeof(ContextMemberMetadataAttribute<>).Name
                    ).SelectMany(p => p.AttributeClass!.TypeArguments).ToArray();
                return new ContextMemberMetadataData()
                {
                    ParentSymbol = ctx.Attributes[0].AttributeClass!.TypeArguments[0],
                    ContextSymbol = ctx.TargetSymbol,
                    ClassSymbols = parentMetadata,
                };

            });


            context.RegisterSourceOutput(contextMetadatas, (context, metadata) =>
            {

                var args = MetadataSourceGeneratorExtensions.BuildCtorParameterSyntaxExpression(metadata.ParentSymbol).ToArray();
                var members = metadata.BuildContextPropertiesExpression(metadata.ParentSymbol).ToArray();
                var assignmentMemeberExpression = members.BuildAssignmentMemeberExpression().ToArray();
                var mainCtor = MetadataSourceGeneratorExtensions.BuildDerivedCtorMethodExpression(metadata.ContextSymbol, args, assignmentMemeberExpression);
                var classDeclaration = MetadataSourceGeneratorExtensions.CreateClassDeclarationSyntaxExpression(metadata.ContextSymbol, metadata.ParentSymbol, [.. members, mainCtor]);
                var namespaceDeclaration = MetadataSourceGeneratorExtensions.BuildNamespaceExpression(metadata.ContextSymbol, classDeclaration);
                context.AddSource($"{metadata.ContextSymbol.ToDisplayString()}.g.cs", namespaceDeclaration.NormalizeWhitespace().ToFullString());

            });

        }


        public static void Test()
        {
            // Create the function pointer type using SyntaxFactory
            var functionPointer = SyntaxFactory.FunctionPointerType(
                    SyntaxFactory.FunctionPointerCallingConvention(
                        SyntaxFactory.Token(SyntaxKind.UnmanagedKeyword),
                        SyntaxFactory.FunctionPointerUnmanagedCallingConventionList(
                            SyntaxFactory.SeparatedList(
                            [
                                SyntaxFactory.FunctionPointerUnmanagedCallingConvention(SyntaxFactory.Identifier("Cdecl")),
                                SyntaxFactory.FunctionPointerUnmanagedCallingConvention(SyntaxFactory.Identifier("SuppressGCTransition"))
                            ])
                        )
                    ),
                    SyntaxFactory.FunctionPointerParameterList(
                        SyntaxFactory.SeparatedList(
                        [
                            SyntaxFactory.FunctionPointerParameter(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword))),
                            SyntaxFactory.FunctionPointerParameter(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword))).WithModifiers([SyntaxFactory.Token( SyntaxKind.OutKeyword)]),
                            SyntaxFactory.FunctionPointerParameter(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)))
                        ])
                    )
                );

            // Generate the delegate field
            var delegateField = SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(functionPointer)
                .AddVariables(SyntaxFactory.VariableDeclarator("GetGoldPtr")))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword));

        }
    }


}