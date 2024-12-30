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


        #region Common

        public static IEnumerable<IParameterSymbol> GetCtorParameterSymbolExpression(ISymbol symbol)
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
                    yield return arg;
                }
            }
        }
        public static IEnumerable<ParameterSyntax> BuildCtorParameterSyntaxExpression(IEnumerable<IParameterSymbol> parameterSymbols)
        {
            foreach (var arg in parameterSymbols)
            {
                yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                       .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()));
            }
        }
        public static IEnumerable<ParameterSyntax> BuildCtorParameterSyntaxExpression(ISymbol symbol)
        {
            return BuildCtorParameterSyntaxExpression(GetCtorParameterSymbolExpression(symbol));
        }

        public static ConstructorDeclarationSyntax BuildDerivedCtorMethodExpression(ISymbol symbol,
            ParameterSyntax[] parameterSyntaxes, IEnumerable<StatementSyntax> statementSyntaxes)
        {
            var args = parameterSyntaxes.Select(p => SyntaxFactory.Argument(SyntaxFactory.IdentifierName(p.Identifier))).ToArray();
            return BuildDerivedCtorMethodExpression(symbol, parameterSyntaxes, args, statementSyntaxes);
        }

        public static ConstructorDeclarationSyntax BuildDerivedCtorMethodExpression(ISymbol symbol,
           ParameterSyntax[] parameterSyntaxes, ArgumentSyntax[] args, IEnumerable<StatementSyntax> statementSyntaxes)
        {

            return SyntaxFactory.ConstructorDeclaration(SyntaxFactory.Identifier(symbol.Name))
                   .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                   .AddParameterListParameters(parameterSyntaxes)
                   .WithInitializer(SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer,
                       SyntaxFactory.ArgumentList([.. args])
                   ))
                   .WithBody(SyntaxFactory.Block(statementSyntaxes));
        }


        public static IEnumerable<StatementSyntax> BuildAssignmentMemeberExpression(this IEnumerable<PropertyDeclarationSyntax> propertyDeclarations)
        {


            foreach (var prop in propertyDeclarations)
            {

                yield return SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(
                   SyntaxKind.SimpleAssignmentExpression,
                   SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.ThisExpression(), SyntaxFactory.IdentifierName(prop.Identifier)),
                   SyntaxFactory.ObjectCreationExpression(prop.Type)
                   .WithArgumentList(SyntaxFactory.ArgumentList([
                             SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                       ]))
                    ));
            }

        }

        public static ClassDeclarationSyntax SetDerivedClassMemberExpression(
            ISymbol symbol,
            ISymbol baseSymbol,
            SyntaxList<MemberDeclarationSyntax> memberDeclarations
            )
        {
            var classDeclaration = SyntaxFactory.ClassDeclaration(symbol.Name)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithBaseList(SyntaxFactory.BaseList([SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(baseSymbol.ToDisplayString()))]))
                .WithMembers(memberDeclarations);
            return classDeclaration;
        }

        public static NamespaceDeclarationSyntax BuildNamespaceExpression(ISymbol symbol,
            params ClassDeclarationSyntax[] classDeclarationSyntaxes)
        {
            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(symbol.ContainingNamespace.ToDisplayString()))
                .WithMembers([.. classDeclarationSyntaxes]);
        }


        #endregion

        #region ContextPropertyMetadataData
        public static IEnumerable<PropertyDeclarationSyntax> BuildContextPropertiesExpression(this ContextMemberMetadataData contextProperties, ISymbol parentSymbol)
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
                //foreach (var ctor in namedTypeSymbol.Constructors)
                //{
                //    if (false == ctor.Parameters.Any(p => SymbolEqualityComparer.Default.Equals(p.Type, parentSymbol)))
                //    {
                //        MetadataSourceGeneratorException.Throw<PropertyDeclarationSyntax>($"{symbol.ToDisplayString()}.ctor Parameters not found:{parentSymbol.ToDisplayString()}");
                //        yield break;
                //    }
                //}
                var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(symbol.ToDisplayString()), symbol.Name)
                  .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                  .WithAccessorList(
                    SyntaxFactory.AccessorList([SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))])
                    );

                yield return propertyDeclaration;
            }
        }


        #endregion



        #region ClassPropertyMetadataData

        public static IEnumerable<ParameterSyntax> BuildClassParentCtorParameterExpression(IEnumerable<IParameterSymbol> parameterSymbols, ulong code)
        {
            foreach (var arg in parameterSymbols)
            {
                var parameter = SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                           .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()));

                if (arg.Type.SpecialType == SpecialType.System_UInt64)
                {
                    parameter = parameter.WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(code))));
                }
                yield return parameter;
            }
        }

        #endregion





    }
}
