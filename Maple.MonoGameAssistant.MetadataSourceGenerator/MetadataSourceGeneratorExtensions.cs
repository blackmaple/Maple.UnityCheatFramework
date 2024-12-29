using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
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


        public static NamespaceDeclarationSyntax BuildContextMetadataNamespaceExpression(this ContextPropertyMetadataData contextProperties,
            params ClassDeclarationSyntax[] classDeclarationSyntaxes)
        {
            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(contextProperties.ContextSymbol.ContainingNamespace.ToDisplayString()))
                .WithMembers([.. classDeclarationSyntaxes]);
        }

        public static ClassDeclarationSyntax BuildContextMetadataClassExpression(
            this ContextPropertyMetadataData contextProperties,
            ISymbol baseSymbol,
            ConstructorDeclarationSyntax constructorDeclarationSyntax,
            PropertyDeclarationSyntax[] propertyDeclarationSyntaxes
            )
        {
            var classDeclaration = SyntaxFactory.ClassDeclaration(contextProperties.ContextSymbol.Name)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithBaseList(SyntaxFactory.BaseList([SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(baseSymbol.ToDisplayString()))]))
                .WithMembers([.. propertyDeclarationSyntaxes, constructorDeclarationSyntax]);
            return classDeclaration;
        }

        public static ConstructorDeclarationSyntax BuildContextMetadataCtorExpression(this ContextPropertyMetadataData contextProperties,
            ParameterSyntax[] parameterSyntaxes, PropertyDeclarationSyntax[] propertyDeclarations)
        {

            return SyntaxFactory.ConstructorDeclaration(SyntaxFactory.Identifier(contextProperties.ContextSymbol.Name))
                   .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                   .AddParameterListParameters(parameterSyntaxes)
                   .WithInitializer(SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer, SyntaxFactory.ArgumentList(
                            SyntaxFactory.SeparatedList([.. parameterSyntaxes.Select(p => SyntaxFactory.Argument(SyntaxFactory.IdentifierName(p.Identifier)))])
                        )))
                   .WithBody(SyntaxFactory.Block(propertyDeclarations.SetContextPropertiesValueExpression()));
        }

        public static IEnumerable<ParameterSyntax> BuildParameterSyntaxExpression(this ISymbol symbol)
        {
            if (symbol is not INamedTypeSymbol namedTypeSymbol)
            {
                MetadataSourceGeneratorException.Throw<ParameterSyntax>($"{nameof(ISymbol)}:{symbol.ToDisplayString()} is not {nameof(INamedTypeSymbol)}");
                yield break;
            }
            if (namedTypeSymbol.Constructors.Length > 1)
            {
                MetadataSourceGeneratorException.Throw<ParameterSyntax>($"{symbol.ToDisplayString()}.ctor Number:{namedTypeSymbol.Constructors.Length}");
                yield break;
            }
            foreach (var ctor in namedTypeSymbol.Constructors)
            {
                foreach (var arg in ctor.Parameters)
                {
                    yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                        .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()));
                }
            }
        }

        public static IEnumerable<PropertyDeclarationSyntax> BuildContextPropertiesExpression(this ContextPropertyMetadataData contextProperties, ISymbol parentSymbol)
        {
            foreach (var symbol in contextProperties.ClassSymbols)
            {
                if (symbol is not INamedTypeSymbol namedTypeSymbol)
                {
                    MetadataSourceGeneratorException.Throw<PropertyDeclarationSyntax>($"{nameof(ISymbol)}:{symbol.ToDisplayString()} is not {nameof(INamedTypeSymbol)}");
                    yield break;
                }
                if (namedTypeSymbol.Constructors.Length > 1)
                {
                    MetadataSourceGeneratorException.Throw<PropertyDeclarationSyntax>($"{symbol.ToDisplayString()}.ctor Number:{namedTypeSymbol.Constructors.Length}");
                    yield break;
                }
                foreach (var ctor in namedTypeSymbol.Constructors)
                {
                    if (false == ctor.Parameters.Any(p => SymbolEqualityComparer.Default.Equals(p.Type, parentSymbol)))
                    {
                        MetadataSourceGeneratorException.Throw<PropertyDeclarationSyntax>($"{symbol.ToDisplayString()}.ctor Parameters not found:{parentSymbol.ToDisplayString()}");
                        yield break;
                    }
                }
                var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(symbol.ToDisplayString()), symbol.Name)
                  .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                  .WithAccessorList(
                    SyntaxFactory.AccessorList([SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))])
                    );

                yield return propertyDeclaration;
            }
        }

        public static IEnumerable<StatementSyntax> SetContextPropertiesValueExpression(this IEnumerable<PropertyDeclarationSyntax> propertyDeclarations)
        {


            foreach (var prop in propertyDeclarations)
            {

                yield return SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(
                   SyntaxKind.SimpleAssignmentExpression,
                   SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.ThisExpression(), SyntaxFactory.IdentifierName(prop.Identifier)),
                   SyntaxFactory.ObjectCreationExpression(prop.Type)
                   .WithArgumentList(SyntaxFactory.ArgumentList([
                             SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                             SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(112555UL)))
                       ]))
                    ));
            }

        }
    }
}
