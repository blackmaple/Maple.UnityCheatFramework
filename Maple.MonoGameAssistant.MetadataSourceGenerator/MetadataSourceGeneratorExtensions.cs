using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public static class MetadataSourceGeneratorExtensions
    {
        #region Helper

        static AttributeSyntax NewAttribute<T_Attribute, T_ARG>(string value) where T_Attribute : Attribute
        {
            return SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(T_Attribute).FullName))
                      .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                      [
                          SyntaxFactory.AttributeArgument(
                                             SyntaxFactory.MemberAccessExpression(
                                                 SyntaxKind.SimpleMemberAccessExpression,
                                                 SyntaxFactory.ParseName(typeof(T_ARG).FullName),
                                                 SyntaxFactory.IdentifierName(value)
                                             )
                                        )

                      ]));

        }
        static T? GetAttributeValue_NamedArgs<T>(this AttributeData attributeData, string name, T def)
        {
            var nVal = attributeData.NamedArguments.FirstOrDefault(p => p.Key == name).Value;
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.Values.IsDefault)
                {
                    return default;
                }
                if (nVal.Values is T arr)
                {
                    return arr;
                }
            }
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                return (T?)nVal.Value;
            }
            else if (nVal.Value is T val2)
            {
                return val2;
            }
            return def;
        }
        static bool TryGetAttributeValue_CtorArgs<T>(this AttributeData attributeData, int index, out T? val)
        {
            Unsafe.SkipInit(out val);
            var nVal = attributeData.ConstructorArguments.ElementAtOrDefault(index);
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.IsNull)
                {
                    val = default;
                    return true;
                }

                if (nVal.Values is T arr)
                {
                    val = arr;
                    return true;
                }
            }
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                val = (T?)nVal.Value;
                return true;
            }
            else if (nVal.Value is T val2)
            {
                val = val2;
                return true;
            }

            return false;
        }
        static bool TryReadImmutableArray<T>(this ImmutableArray<TypedConstant> offsetSymbols, out T[]? values)
        // where T : struct
        {
            if (offsetSymbols.IsDefault)
            {
                values = default;
                return false;
            }
            if (offsetSymbols.IsEmpty)
            {
                values = [];
            }
            else
            {
                values = [.. EnumImmutableArray()];
            }
            return true;
            IEnumerable<T> EnumImmutableArray()
            {
                foreach (var subMember in offsetSymbols)
                {
                    if (subMember.Value is T val)
                    {
                        yield return val;
                    }
                }
            }

        }
        static string ArrayDisplay<T>(this IEnumerable<T> arr)
            where T : struct
        {
            return $@"[{string.Join(", ", arr)}]";
        }

        #endregion

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
                   .WithParameterList(SyntaxFactory.ParameterList([.. parameterSyntaxes]))
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

        public static ClassDeclarationSyntax CreateClassDeclarationSyntaxExpression(
            ISymbol symbol,
            ISymbol baseSymbol,
            SyntaxList<MemberDeclarationSyntax> memberDeclarations)
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

        public static StructDeclarationSyntax CreateStructDeclarationSyntaxExpression(ISymbol symbol, SyntaxList<MemberDeclarationSyntax> memberDeclarations)
        {
            var structDeclaration = SyntaxFactory.StructDeclaration(symbol.Name)
               .WithModifiers([SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
               .WithMembers(memberDeclarations);
            return structDeclaration;

        }
        #endregion


        #region ContextMemberMetadataData
        public static ContextMemberMetadataData GetContextMemberMetadataData(this GeneratorAttributeSyntaxContext ctx, AttributeData att)
        {
            var parentMetadata =
                ctx.TargetSymbol.GetAttributes().Where(p =>
                       p.AttributeClass!.ContainingNamespace.ToDisplayString() == typeof(ContextMemberMetadataAttribute<>).Namespace
                       && p.AttributeClass.MetadataName == typeof(ContextMemberMetadataAttribute<>).Name
                       ).SelectMany(p => p.AttributeClass!.TypeArguments).ToArray();


            if (false == att.TryGetAttributeValue_CtorArgs<bool>(0, out var export))
            {
                export = false;
            }

            return new ContextMemberMetadataData()
            {
                ParentSymbol = att.AttributeClass!.TypeArguments[0],
                ContextSymbol = ctx.TargetSymbol,
                ClassSymbols = parentMetadata,
                ExportJson = export
            };
        }

        #endregion

        #region ContextPropertyMetadataData

        public static IEnumerable<PropertyDeclarationSyntax> BuildContextPropertiesExpression(this ContextMemberMetadataData contextProperties)
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


        public static PropertyDeclarationSyntax BuildContextJsonField(this ContextMemberMetadataData contextProperties)
        {
            return contextProperties.BuildContextJsonCommon<MonoJsonFieldDTO>(nameof(MonoJsonFieldDTO));
        }
        public static PropertyDeclarationSyntax BuildContextJsonMethod(this ContextMemberMetadataData contextProperties)
        {
            return contextProperties.BuildContextJsonCommon<MonoJsonMethodDTO>(nameof(MonoJsonMethodDTO));
        }
        public static PropertyDeclarationSyntax BuildContextJsonClass(this ContextMemberMetadataData contextProperties)
        {
            return contextProperties.BuildContextJsonCommon<MonoJsonClassDTO>(nameof(MonoJsonClassDTO), false);
        }

        public static PropertyDeclarationSyntax BuildContextJsonCommon<T>(this ContextMemberMetadataData contextProperties, string name, bool array = true)
        {

            var baseType = SyntaxFactory.ParseTypeName(typeof(T).FullName);

            var arrayType = SyntaxFactory.ArrayType(baseType)
              .WithRankSpecifiers(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                SyntaxFactory.OmittedArraySizeExpression()))));


            var body = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(arrayType, name)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithAccessorList(SyntaxFactory.AccessorList([body]))
                .WithInitializer(
                    SyntaxFactory.EqualsValueClause(
                        SyntaxFactory.CollectionExpression(
                             SyntaxFactory.SeparatedList<CollectionElementSyntax>(
                              (contextProperties.ExportJson ? EnumMemberAccessExpressionSyntax(contextProperties.ClassSymbols, name, array) : [])
                            )
                        )
                    )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;

            static IEnumerable<CollectionElementSyntax> EnumMemberAccessExpressionSyntax(ISymbol[] classSymbols, string name, bool array = true)
            {
                foreach (var symbol in classSymbols)
                {
                    if (array)
                    {
                        yield return
                           SyntaxFactory.SpreadElement(
                           SyntaxFactory.MemberAccessExpression(
                               SyntaxKind.SimpleMemberAccessExpression,
                               SyntaxFactory.IdentifierName(symbol.ToDisplayString()),
                               SyntaxFactory.IdentifierName(name)
                           ));
                    }
                    else
                    {
                        yield return
                          SyntaxFactory.ExpressionElement(
                          SyntaxFactory.MemberAccessExpression(
                              SyntaxKind.SimpleMemberAccessExpression,
                              SyntaxFactory.IdentifierName(symbol.ToDisplayString()),
                              SyntaxFactory.IdentifierName(name)
                          ));
                    }

                }
            }
        }


        public static void BuildContextJson(this ContextMemberMetadataData contextProperties, List<MemberDeclarationSyntax> members)
        {
            members.AddRange([BuildContextBuildVersion(), contextProperties.BuildContextJsonClass(), contextProperties.BuildContextJsonMethod(), contextProperties.BuildContextJsonField()]);
        }

        public static PropertyDeclarationSyntax BuildContextBuildVersion()
        {
            var baseType = SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(baseType, nameof(Version))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                         SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(DateTime.Now.ToString("yyyyMMddHHmmss")))
                        )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;


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

        #region ClassMemberMetadataData
        public static ClassMemberMetadataData GetClassMemberMetadataData(this GeneratorAttributeSyntaxContext ctx, AttributeData att)
        {
            var parentMetadata = ctx.TargetSymbol.GetAttributes().Where(p =>
              p.AttributeClass!.ContainingNamespace.ToDisplayString() == typeof(ClassParentMetadataAttribute<,>).Namespace
              && p.AttributeClass.MetadataName == typeof(ClassParentMetadataAttribute<,>).Name
              ).FirstOrDefault();
            if (parentMetadata is null)
            {
                return MetadataSourceGeneratorException.Throw<ClassMemberMetadataData>($"{ctx.TargetSymbol.ToDisplayString()} not found {typeof(ClassParentMetadataAttribute<,>).FullName}");
            }
            var ptrSymbol = parentMetadata.AttributeClass!.TypeArguments[1];
            var metadata = new ClassMemberMetadataData()
            {
                Code = MetadataSourceGeneratorCounter.Increment(),
                ParentSymbol = parentMetadata.AttributeClass.TypeArguments[0],
                PtrSymbol = ptrSymbol,
                ContextSymbol = ctx.TargetSymbol,

                PropertyMetadataDatas = [.. ptrSymbol.EnumClassPropertyMetadata().OrderBy(p => p.PropertySymbol.IsStatic ? 1 : 0)],
                MethodMetadataDatas = [.. ptrSymbol.EnumClassMethodMetadata().OrderBy(p => p.RuntimeMethod ? 1 : 0)]
            };

            if (att.TryGetAttributeValue_CtorArgs(0, out ImmutableArray<TypedConstant> arrName) && arrName.TryReadImmutableArray(out byte[]? utf8ImageName))
            {
                metadata.Utf8ImageName = utf8ImageName;
            }
            if (att.TryGetAttributeValue_CtorArgs(1, out arrName) && arrName.TryReadImmutableArray(out byte[]? utf8Namespace))
            {
                metadata.Utf8Namespace = utf8Namespace;
            }
            if (att.TryGetAttributeValue_CtorArgs(2, out arrName) && arrName.TryReadImmutableArray(out byte[]? utf8ClassName))
            {
                metadata.Utf8ClassName = utf8ClassName;
            }
            if (att.TryGetAttributeValue_CtorArgs(3, out arrName) && arrName.TryReadImmutableArray(out byte[]? utf8FullName))
            {
                metadata.Utf8FullName = utf8FullName;
            }
            return metadata;

        }
        public static IEnumerable<ClassPropertyMetadataData> EnumClassPropertyMetadata(this ITypeSymbol ptrSymbol)
        {
            foreach (var member in ptrSymbol.GetMembers())
            {
                if (member.Kind != SymbolKind.Property)
                {
                    continue;
                }
                if (member is not IPropertySymbol propertySymbol)
                {
                    continue;
                }
                if (propertySymbol.IsPartialDefinition == false)
                {
                    continue;
                }
                var att = propertySymbol.GetAttributes().Where(p => p.AttributeClass!.ToDisplayString() == typeof(ClassPropertyMetadataAttribute).FullName).FirstOrDefault();
                if (att is not null)
                {

                    var metadata = new ClassPropertyMetadataData()
                    {
                        PropertySymbol = propertySymbol,
                    };
                    if (att.TryGetAttributeValue_CtorArgs(0, out ImmutableArray<TypedConstant> arrName) && arrName.TryReadImmutableArray(out byte[]? utf8Name))
                    {
                        metadata.Utf8PropertyName = utf8Name;
                    }
                    if (att.TryGetAttributeValue_CtorArgs(1, out ImmutableArray<TypedConstant> arrType) && arrType.TryReadImmutableArray(out byte[]? utf8Type))
                    {
                        metadata.Utf8PropertyType = utf8Type;
                    }
                    metadata.Code = MetadataSourceGeneratorCounter.Increment();
                    yield return metadata;
                }
            }

        }
        public static IEnumerable<ClassMethodMetadataData> EnumClassMethodMetadata(this ITypeSymbol ptrSymbol)
        {
            foreach (var member in ptrSymbol.GetMembers())
            {
                if (member.Kind != SymbolKind.Method)
                {
                    continue;
                }
                if (member is not IMethodSymbol methodSymbol)
                {
                    continue;
                }
                if (methodSymbol.IsPartialDefinition == false)
                {
                    continue;
                }
                var att = methodSymbol.GetAttributes().Where(p => p.AttributeClass!.ToDisplayString() == typeof(ClassMethodMetadataAttribute).FullName).FirstOrDefault();
                if (att is not null)
                {
                    var metadata = new ClassMethodMetadataData()
                    {
                        MethodSymbol = methodSymbol,
                    };
                    if (att.TryGetAttributeValue_CtorArgs(0, out ImmutableArray<TypedConstant> arrName) && arrName.TryReadImmutableArray(out byte[]? utf8Name))
                    {
                        metadata.Utf8MethodName = utf8Name;
                    }
                    if (att.TryGetAttributeValue_CtorArgs(1, out ImmutableArray<TypedConstant> arrType) && arrType.TryReadImmutableArray(out byte[]? utf8Type))
                    {
                        metadata.Utf8MethodReturnType = utf8Type;
                    }


                    var callTypes = att.GetAttributeValue_NamedArgs<ImmutableArray<TypedConstant>>(nameof(ClassMethodMetadataAttribute.CallConvs), []);
                    if (callTypes.TryReadImmutableArray<ISymbol>(out var callConvs))
                    {
                        metadata.CallConvs = callConvs;
                    }

                    metadata.RuntimeMethod = att.GetAttributeValue_NamedArgs(nameof(ClassMethodMetadataAttribute.RuntimeMethodAsThis), false);
                    if (TryEnumMethodParameterTypes(metadata.MethodSymbol, out var parameterTypes))
                    {
                        metadata.Utf8MethodParameterTypes = parameterTypes;
                    }
                    metadata.Code = MetadataSourceGeneratorCounter.Increment();


                    yield return metadata;
                }
            }

            static bool TryEnumMethodParameterTypes(IMethodSymbol methodSymbol, out byte[]?[]? values)
            {
                var attributeDatas = methodSymbol.GetAttributes().Where(p => p.AttributeClass is not null && p.AttributeClass.ToDisplayString() == typeof(ClassMethodParameterMetadataAttribute).FullName).ToArray();
                if (attributeDatas.Length != 0)
                {
                    values = [.. EnumMethodParameterTypes().OrderBy(p => p.order).Select(p => p.utf8Parameter)];
                    return true;
                }
                values = null;
                return false;
                IEnumerable<(byte[]? utf8Parameter, int order)> EnumMethodParameterTypes()
                {
                    foreach (var att in attributeDatas)
                    {
                        byte[]? utf8Parameter = default;
                        if (att.TryGetAttributeValue_CtorArgs(0, out ImmutableArray<TypedConstant> arrType) && arrType.TryReadImmutableArray(out utf8Parameter))
                        {

                        }
                        if (att.TryGetAttributeValue_CtorArgs(1, out int order))
                        {

                        }
                        yield return (utf8Parameter, order);
                    }
                }

            }
        }

        public static FieldDeclarationSyntax BuildOffsetMemberExpression(ClassPropertyMetadataData classProperty)
        {
            VariableDeclarationSyntax variableDeclaration =
                classProperty.PropertySymbol.IsStatic ?
                SyntaxFactory.VariableDeclaration(
                   SyntaxFactory.IdentifierName(typeof(MonoStaticFieldSource).FullName),
                   [SyntaxFactory.VariableDeclarator(classProperty.GetOffsetVariableName())])
                : SyntaxFactory.VariableDeclaration(
                       SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)),
                   [SyntaxFactory.VariableDeclarator(classProperty.GetOffsetVariableName())]);

            return SyntaxFactory.FieldDeclaration(variableDeclaration).WithModifiers([SyntaxFactory.Token(SyntaxKind.StaticKeyword)]);

        }
        public static ExpressionStatementSyntax AssignmentOffsetMemberExpression(ISymbol contextSymbol, ClassPropertyMetadataData classProperty)
        {
            var callMethod = classProperty.PropertySymbol.IsStatic
                ? nameof(IClassMetadataCollector.GetStaticFieldMetadata)
                : nameof(IClassMetadataCollector.GetMemberFieldOffset);
            return SyntaxFactory.ExpressionStatement
                    (
                        SyntaxFactory.AssignmentExpression
                        (
                             SyntaxKind.SimpleAssignmentExpression,
                             SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()), SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())),
                                SyntaxFactory.InvocationExpression
                                (
                                    SyntaxFactory.MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.ThisExpression(),
                                        SyntaxFactory.IdentifierName(callMethod)
                                    )
                                ).WithArgumentList(SyntaxFactory.ArgumentList(
                                [
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(classProperty.Code)))
                                ]
                                ))
                        )
                    );



        }
        public static PropertyDeclarationSyntax BuildPartialPropertyMemberExpression(ISymbol contextSymbol, ClassPropertyMetadataData classProperty)
        {
            // classProperty.PropertySymbol.DeclaredAccessibility = Accessibility.



            var propType = SyntaxFactory.ParseTypeName(classProperty.PropertySymbol.Type.ToDisplayString());
            var classfullName = SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString());

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(propType, classProperty.PropertySymbol.Name)
                .WithModifiers([.. EnumModifiers(classProperty)])
                .WithAccessorList(SyntaxFactory.AccessorList([.. EnumAccessorDeclarationSyntax(classfullName, propType, classProperty)]));

            return propertyDeclaration;

            static IEnumerable<SyntaxToken> EnumModifiers(ClassPropertyMetadataData classProperty)
            {
                if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Public)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                }
                if (classProperty.PropertySymbol.IsStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                }
                if (classProperty.PropertySymbol.IsPartialDefinition)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                }
            }

            static IEnumerable<AccessorDeclarationSyntax> EnumAccessorDeclarationSyntax(IdentifierNameSyntax classfullName, TypeSyntax propType, ClassPropertyMetadataData classProperty)
            {
                if (classProperty.PropertySymbol.IsStatic)
                {
                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        var getAccessorBody =
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                            .WithBody(
                               SyntaxFactory.Block(
                                   SyntaxFactory.ReturnStatement(
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                classfullName,
                                                SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                            )

                                        )
                                        .WithArgumentList(
                                            SyntaxFactory.ArgumentList(
                                            [
                                                SyntaxFactory.Argument(
                                                    SyntaxFactory.MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        classfullName,
                                                        SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                                    )
                                                )
                                            ])
                                        )
                                    )
                                )
                            );

                        yield return getAccessorBody;
                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        var setAccessorBody =
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                            .WithBody(
                                SyntaxFactory.Block
                                (
                                    SyntaxFactory.ExpressionStatement(
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                classfullName,
                                                SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                            ),
                                            SyntaxFactory.ArgumentList(
                                            [
                                                SyntaxFactory.Argument(
                                                    SyntaxFactory.MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        classfullName,
                                                        SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                                    )),
                                                SyntaxFactory.Argument(SyntaxFactory.DeclarationExpression(
                                                    SyntaxFactory.IdentifierName("in"),
                                                    SyntaxFactory.SingleVariableDesignation(SyntaxFactory.Identifier("value"))))
                                            ])
                                        )
                                    )
                                )
                            );
                        yield return setAccessorBody;

                    }
                }
                else
                {
                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        var getAccessorBody =
                             SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                            .WithBody(
                                SyntaxFactory.Block(
                                    SyntaxFactory.ReturnStatement(
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                classfullName,
                                                SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetMemberFieldValue)))
                                                    .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                            )
                                        ).WithArgumentList(
                                            SyntaxFactory.ArgumentList(
                                            [
                                                SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                                SyntaxFactory.Argument(
                                                    SyntaxFactory.MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        classfullName,
                                                        SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())))
                                            ])
                                        )
                                    )
                                )
                            );

                        yield return getAccessorBody;

                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        var setAccessorBody =
                             SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                            .WithBody(
                                SyntaxFactory.Block(
                                    SyntaxFactory.ExpressionStatement(
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                classfullName,
                                                SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetMemberFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                            ),
                                            SyntaxFactory.ArgumentList(
                                            [
                                                SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                                SyntaxFactory.Argument
                                                (
                                                    SyntaxFactory.MemberAccessExpression
                                                    (
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        classfullName,
                                                        SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                                    )
                                                ),

                                                SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")).WithRefKindKeyword(SyntaxFactory.Token( SyntaxKind.InKeyword))
                                            ])
                                        )
                                    )
                                )
                            );


                        yield return setAccessorBody;

                    }
                }
                //yield break;
            }

        }
        public static void BuildClassPartialPropertyExpression(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> fields, List<ExpressionStatementSyntax> expressions, List<StructDeclarationSyntax> structs)
        {
            var propertyDeclarations = new List<PropertyDeclarationSyntax>();
            foreach (var member in classMember.PropertyMetadataDatas)
            {
                var f = BuildOffsetMemberExpression(member);
                fields.Add(f);

                var s = AssignmentOffsetMemberExpression(classMember.ContextSymbol, member);
                expressions.Add(s);

                var p = BuildPartialPropertyMemberExpression(classMember.ContextSymbol, member);
                propertyDeclarations.Add(p);
            }
            var ptr = CreateStructDeclarationSyntaxExpression(classMember.PtrSymbol, [.. propertyDeclarations]);
            structs.Add(ptr);
        }


        public static StructDeclarationSyntax BuildMethodMemberPointerExpression(ClassMethodMetadataData classMethod)
        {
            var functionPointer = SyntaxFactory.FunctionPointerType(
                    GetFunctionPointerCallingConvention(classMethod),
                    SyntaxFactory.FunctionPointerParameterList(
                        SyntaxFactory.SeparatedList(
                        [
                            ..EnumFunctionPointerParameterSyntax(classMethod),
                            GetFunctionPointerReturnSyntax(classMethod),
                        ])
                    )
                );

            var delegateField = SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(functionPointer)
                .WithVariables([
                        SyntaxFactory.VariableDeclarator(classMethod.GetDelegatePointerStructMemberName())
                        .WithInitializer(SyntaxFactory.EqualsValueClause(
                               SyntaxFactory.CastExpression(
                                    functionPointer,
                                    SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCtorArgName())
                                   )
                            ))
                    ]))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)])
                .WithAttributeLists(
                [
                    SyntaxFactory.AttributeList(
                    [
                        NewAttribute<MarshalAsAttribute,UnmanagedType>(nameof(UnmanagedType.SysInt))
                    ])
                ]);

            var methodDeclaration = SyntaxFactory.MethodDeclaration(GetReturnSyntax(classMethod), classMethod.GetDelegatePointerStructCaller())
                .WithAttributeLists([
                    SyntaxFactory.AttributeList(
                    [
                        NewAttribute<MethodImplAttribute,MethodImplOptions>(nameof(MethodImplOptions.AggressiveInlining))
                    ])
                ])
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                .WithParameterList(SyntaxFactory.ParameterList(
                            SyntaxFactory.SeparatedList(
                            [
                                ..EnumParameterSyntax(classMethod),
                            ])
                ))
                .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                        GetBodyExpressionSyntax(classMethod)
                ))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));



            //

            var operatorDeclaration = SyntaxFactory.ConversionOperatorDeclaration(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword), SyntaxFactory.ParseTypeName(classMethod.GetDelegatePointerStructName()))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
                .WithOperatorKeyword(SyntaxFactory.Token(SyntaxKind.OperatorKeyword))
                .WithParameterList(
                    SyntaxFactory.ParameterList([
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(classMethod.GetDelegatePointerStructCtorArgName()))
                        .WithType(SyntaxFactory.ParseTypeName(typeof(nint).FullName))
                    ])
                )
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.ObjectCreationExpression(
                            SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructName())
                        ).WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCtorArgName()))
                                )
                            )
                         )
                    )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var ptrStruct = SyntaxFactory.StructDeclaration(classMethod.GetDelegatePointerStructName())
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.UnsafeKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)])
                .WithAttributeLists(
                [
                    SyntaxFactory.AttributeList(
                                [
                                    NewAttribute<StructLayoutAttribute,LayoutKind>(nameof(LayoutKind.Sequential)),
                                ])
                ])
                .WithParameterList(SyntaxFactory.ParameterList(
                    [
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(classMethod.GetDelegatePointerStructCtorArgName())).WithType(SyntaxFactory.ParseTypeName(typeof(nint).FullName))
                    ]))
                .WithMembers([delegateField, methodDeclaration, operatorDeclaration]);

            return ptrStruct;

            static FunctionPointerCallingConventionSyntax GetFunctionPointerCallingConvention(ClassMethodMetadataData classMethod)
            {
                if (classMethod.CallConvs is null)
                {
                    return SyntaxFactory.FunctionPointerCallingConvention(SyntaxFactory.Token(SyntaxKind.ManagedKeyword));
                }
                var callTypes = EnumFunctionPointerUnmanagedCallingConventionSyntax(classMethod.CallConvs).ToArray();
                if (callTypes.Length == 0)
                {
                    return
                       SyntaxFactory.FunctionPointerCallingConvention(SyntaxFactory.Token(SyntaxKind.UnmanagedKeyword));
                }
                else
                {
                    return
                        SyntaxFactory.FunctionPointerCallingConvention(
                              SyntaxFactory.Token(SyntaxKind.UnmanagedKeyword),
                              SyntaxFactory.FunctionPointerUnmanagedCallingConventionList(
                                  SyntaxFactory.SeparatedList(
                                  [
                                      ..callTypes
                                  ])
                              )
                        );
                }


                static IEnumerable<FunctionPointerUnmanagedCallingConventionSyntax> EnumFunctionPointerUnmanagedCallingConventionSyntax(ISymbol[] callConvs)
                {
                    foreach (var callConv in callConvs)
                    {
                        yield return SyntaxFactory.FunctionPointerUnmanagedCallingConvention(SyntaxFactory.Identifier(callConv.Name.Replace("CallConv", "")));
                    }

                }


            }
            static IEnumerable<FunctionPointerParameterSyntax> EnumFunctionPointerParameterSyntax(ClassMethodMetadataData classMethod)
            {
                if (classMethod.RuntimeMethod || classMethod.MethodSymbol.IsStatic == false)
                {
                    yield return SyntaxFactory.FunctionPointerParameter(SyntaxFactory.ParseTypeName(typeof(nint).FullName));
                }

                foreach (var arg in classMethod.MethodSymbol.Parameters)
                {
                    yield return SyntaxFactory.FunctionPointerParameter(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()))
                        .WithModifiers([.. EnumParameterModifiers(arg)]);

                }



                static IEnumerable<SyntaxToken> EnumParameterModifiers(IParameterSymbol parameterSymbol)
                {
                    if (parameterSymbol.RefKind == RefKind.Ref)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.Out)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.In)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.InKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.RefReadOnlyParameter)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                        yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                    }

                }

            }
            static FunctionPointerParameterSyntax GetFunctionPointerReturnSyntax(ClassMethodMetadataData classMethod)
            {

                return SyntaxFactory.FunctionPointerParameter(SyntaxFactory.ParseTypeName(classMethod.MethodSymbol.ReturnType.ToDisplayString()))
                  .WithModifiers([.. EnumReturnModifiers(classMethod.MethodSymbol)]);

                static IEnumerable<SyntaxToken> EnumReturnModifiers(IMethodSymbol methodSymbol)
                {
                    if (methodSymbol.ReturnsByRef)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (methodSymbol.ReturnsByRefReadonly)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);

                        yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                    }

                }
            }

            static IEnumerable<ParameterSyntax> EnumParameterSyntax(ClassMethodMetadataData classMethod)
            {
                if (classMethod.RuntimeMethod || classMethod.MethodSymbol.IsStatic == false)
                {
                    yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier($"@{SyntaxFactory.ThisExpression().ToFullString()}")).WithType(SyntaxFactory.ParseTypeName(typeof(nint).FullName));
                }

                foreach (var arg in classMethod.MethodSymbol.Parameters)
                {
                    yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                        .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()))
                        .WithModifiers([.. EnumParameterModifiers(arg)]);

                }



                static IEnumerable<SyntaxToken> EnumParameterModifiers(IParameterSymbol parameterSymbol)
                {
                    if (parameterSymbol.RefKind == RefKind.Ref)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.Out)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.In)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.InKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.RefReadOnlyParameter)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                        yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                    }

                }

            }
            static IEnumerable<ArgumentSyntax> EnumArgumentSyntax(ClassMethodMetadataData classMethod)
            {
                if (classMethod.RuntimeMethod || classMethod.MethodSymbol.IsStatic == false)
                {
                    yield return SyntaxFactory.Argument(SyntaxFactory.IdentifierName($"@{SyntaxFactory.ThisExpression().ToFullString()}"));
                }

                foreach (var arg in classMethod.MethodSymbol.Parameters)
                {
                    yield return SyntaxFactory.Argument(SyntaxFactory.IdentifierName(arg.Name)).WithRefKindKeyword(GetParameterModifiers(arg));
                }
                static SyntaxToken GetParameterModifiers(IParameterSymbol parameterSymbol)
                {
                    if (parameterSymbol.RefKind == RefKind.Ref)
                    {
                        return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.Out)
                    {
                        return SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.In || parameterSymbol.RefKind == RefKind.RefReadOnlyParameter)
                    {
                        return SyntaxFactory.Token(SyntaxKind.InKeyword);
                    }

                    return SyntaxFactory.Token(SyntaxKind.None);
                }

            }
            static ExpressionSyntax GetBodyExpressionSyntax(ClassMethodMetadataData classMethod)
            {
                var baseBody =
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                              SyntaxKind.SimpleMemberAccessExpression,
                              SyntaxFactory.ThisExpression(),
                              SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructMemberName())
                        )
                    )
                    .WithArgumentList(SyntaxFactory.ArgumentList(
                    [
                        ..EnumArgumentSyntax(classMethod)
                    ]));
                if (classMethod.MethodSymbol.ReturnsByRef || classMethod.MethodSymbol.ReturnsByRefReadonly)
                {
                    return SyntaxFactory.RefExpression(baseBody);
                }
                return baseBody;

            }
            static TypeSyntax GetReturnSyntax(ClassMethodMetadataData classMethod)
            {

                TypeSyntax typeSyntax = SyntaxFactory.ParseTypeName(classMethod.MethodSymbol.ReturnType.ToDisplayString());
                if (classMethod.MethodSymbol.ReturnsByRef)
                {

                    return SyntaxFactory.RefType(SyntaxFactory.Token(SyntaxKind.RefKeyword), typeSyntax);

                }
                else if (classMethod.MethodSymbol.ReturnsByRefReadonly)
                {
                    return SyntaxFactory.RefType(SyntaxFactory.Token(SyntaxKind.RefKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword), typeSyntax);
                }

                return typeSyntax;
            }

        }
        public static FieldDeclarationSyntax BuildMethodMemberFieldExpression(ClassMethodMetadataData classMethod, StructDeclarationSyntax functionPointer)
        {

            VariableDeclarationSyntax variableDeclaration =
                classMethod.RuntimeMethod ?
                SyntaxFactory.VariableDeclaration(
                    SyntaxFactory.GenericName(typeof(MonoMethodDelegate).FullName)
                        .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([SyntaxFactory.ParseTypeName(functionPointer.Identifier.Text)])),
                    [SyntaxFactory.VariableDeclarator(classMethod.GetDelegatePointerStaticFieldName())])
                : SyntaxFactory.VariableDeclaration(
                    SyntaxFactory.ParseTypeName(functionPointer.Identifier.Text),
                    [SyntaxFactory.VariableDeclarator(classMethod.GetDelegatePointerStaticFieldName())]);

            return SyntaxFactory.FieldDeclaration(variableDeclaration).WithModifiers([SyntaxFactory.Token(SyntaxKind.StaticKeyword)]);

        }
        public static ExpressionStatementSyntax AssignmentMethodMemberExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod, StructDeclarationSyntax functionPointer)
        {
            var callMethod = SyntaxFactory.MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    SyntaxFactory.ThisExpression(),
                    (
                        classMethod.RuntimeMethod ?
                        SyntaxFactory.GenericName(nameof(IClassMetadataCollector.GetMethodDelegate))
                        .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([SyntaxFactory.ParseTypeName(functionPointer.Identifier.Text)]))
                        : SyntaxFactory.IdentifierName(nameof(IClassMetadataCollector.GetMethodPointer))
                    )
                );
            return SyntaxFactory.ExpressionStatement
                    (
                        SyntaxFactory.AssignmentExpression
                        (
                             SyntaxKind.SimpleAssignmentExpression,
                             SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()), SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())),
                                SyntaxFactory.InvocationExpression
                                (
                                    callMethod
                                ).WithArgumentList(SyntaxFactory.ArgumentList(
                                [
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(classMethod.Code)))
                                ]
                                ))
                        )
                    );

        }
        public static MemberDeclarationSyntax BuildMethodMemberCallExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod)
        {
            return
                SyntaxFactory.MethodDeclaration(GetReturnSyntax(classMethod), classMethod.MethodSymbol.Name)
                .WithModifiers([.. EnumModifiers(classMethod)])
                .WithParameterList(SyntaxFactory.ParameterList([
                    ..EnumParameterSyntax(classMethod)
                ]))
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(GetBodyExpression(contextSymbol, classMethod))
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            static IEnumerable<SyntaxToken> EnumModifiers(ClassMethodMetadataData classMethod)
            {
                if (classMethod.MethodSymbol.DeclaredAccessibility == Accessibility.Public)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                }
                if (classMethod.MethodSymbol.IsStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                }
                if (classMethod.MethodSymbol.IsPartialDefinition)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                }
            }
            static IEnumerable<ParameterSyntax> EnumParameterSyntax(ClassMethodMetadataData classMethod)
            {


                foreach (var arg in classMethod.MethodSymbol.Parameters)
                {
                    yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                        .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()))
                        .WithModifiers([.. EnumParameterModifiers(arg)]);

                }



                static IEnumerable<SyntaxToken> EnumParameterModifiers(IParameterSymbol parameterSymbol)
                {
                    if (parameterSymbol.RefKind == RefKind.Ref)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.Out)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.In)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.InKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.RefReadOnlyParameter)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                        yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                    }

                }

            }
            static IEnumerable<ArgumentSyntax> EnumArgumentSyntax(ISymbol contextSymbol, ClassMethodMetadataData classMethod)
            {
                if (classMethod.RuntimeMethod)
                {
                    yield return SyntaxFactory.Argument(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()),
                                SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())
                             ),
                            SyntaxFactory.IdentifierName(nameof(MonoMethodDelegate<>.RuntimeMethod))
                        )
                    );
                }
                else if (classMethod.MethodSymbol.IsStatic == false)
                {
                    yield return SyntaxFactory.Argument(SyntaxFactory.ThisExpression());
                }


                foreach (var arg in classMethod.MethodSymbol.Parameters)
                {
                    yield return SyntaxFactory.Argument(SyntaxFactory.IdentifierName(arg.Name)).WithRefKindKeyword(GetParameterModifiers(arg));
                }
                static SyntaxToken GetParameterModifiers(IParameterSymbol parameterSymbol)
                {
                    if (parameterSymbol.RefKind == RefKind.Ref)
                    {
                        return SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.Out)
                    {
                        return SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    }
                    else if (parameterSymbol.RefKind == RefKind.In || parameterSymbol.RefKind == RefKind.RefReadOnlyParameter)
                    {
                        return SyntaxFactory.Token(SyntaxKind.InKeyword);
                    }

                    return SyntaxFactory.Token(SyntaxKind.None);
                }

            }
            static InvocationExpressionSyntax GetInvocationExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod)
            {
                if (classMethod.RuntimeMethod)
                {
                    //DemoGameSystem.s_Delegate_GetGlod_0.f.GetDelegatePointerStructCaller
                    return
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()),
                                    SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())
                                ),
                                SyntaxFactory.IdentifierName(nameof(MonoMethodDelegate<>.MethodPointer))
                            ),
                            SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCaller())
                        )
                    );
                }

                return
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()),
                            SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())
                        ),
                        SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCaller())
                    )
                );

            }
            static TypeSyntax GetReturnSyntax(ClassMethodMetadataData classMethod)
            {

                TypeSyntax typeSyntax = SyntaxFactory.ParseTypeName(classMethod.MethodSymbol.ReturnType.ToDisplayString());
                if (classMethod.MethodSymbol.ReturnsByRef)
                {

                    return SyntaxFactory.RefType(SyntaxFactory.Token(SyntaxKind.RefKeyword), typeSyntax);

                }
                else if (classMethod.MethodSymbol.ReturnsByRefReadonly)
                {
                    return SyntaxFactory.RefType(SyntaxFactory.Token(SyntaxKind.RefKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword), typeSyntax);
                }

                return typeSyntax;
            }

            static ExpressionSyntax GetBodyExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod)
            {
                var baseBody = GetInvocationExpression(contextSymbol, classMethod)
                                  .WithArgumentList(SyntaxFactory.ArgumentList(
                                   [
                                       ..EnumArgumentSyntax(contextSymbol,classMethod)
                                   ]));
                if (classMethod.MethodSymbol.ReturnsByRef || classMethod.MethodSymbol.ReturnsByRefReadonly)
                {

                    return SyntaxFactory.RefExpression(baseBody);

                }
                return baseBody;


            }
        }

        public static void BuildClassPartialMethodExpression(this ClassMemberMetadataData classMember,
            List<StructDeclarationSyntax> structs,
            List<MemberDeclarationSyntax> fields,
            List<ExpressionStatementSyntax> expressions)
        {
            List<MemberDeclarationSyntax> members = [];
            foreach (var member in classMember.MethodMetadataDatas)
            {
                var s = BuildMethodMemberPointerExpression(member);
                structs.Add(s);

                var f = BuildMethodMemberFieldExpression(member, s);
                fields.Add(f);

                var e = AssignmentMethodMemberExpression(classMember.ContextSymbol, member, s);
                expressions.Add(e);

                var m = BuildMethodMemberCallExpression(classMember.ContextSymbol, member);
                members.Add(m);
            }
            var ptr = CreateStructDeclarationSyntaxExpression(classMember.PtrSymbol, [.. members]);
            structs.Add(ptr);

        }


        //public static ExpressionSyntax ArrayInitializerExpression(byte[]? bytes)
        //{
        //    return ArrayInitializerExpression(bytes, EnumLiteralExpression);
        //    static IEnumerable<LiteralExpressionSyntax> EnumLiteralExpression(byte[] bytes)
        //    {
        //        foreach (var b in bytes)
        //        {
        //            yield return SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(b));
        //        }

        //    }
        //}
        //public static ExpressionSyntax ArrayInitializerExpression(byte[]?[]? arrayBytes)
        //{
        //    return ArrayInitializerExpression(arrayBytes, EnumLiteralExpression);
        //    static IEnumerable<ExpressionSyntax> EnumLiteralExpression(byte[]?[] arrayBytes)
        //    {
        //        foreach (byte[]? bytes in arrayBytes)
        //        {
        //            yield return ArrayInitializerExpression(bytes);
        //        }
        //    }

        //}

        //public static ExpressionSyntax ArrayInitializerExpression<T>(T[]?[]? arrItems, Func<T[]?[], IEnumerable<ExpressionSyntax>> func)
        //{
        //    var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName))
        //        .WithRankSpecifiers([
        //            SyntaxFactory.ArrayRankSpecifier([
        //                SyntaxFactory.OmittedArraySizeExpression()
        //            ]),
        //            SyntaxFactory.ArrayRankSpecifier([
        //                SyntaxFactory.OmittedArraySizeExpression()
        //            ])
        //        ]);

        //    if (arrItems is null)
        //    {
        //        return SyntaxFactory.DefaultExpression(arrayType);
        //    }

        //    return
        //    SyntaxFactory.ArrayCreationExpression(arrayType)
        //    .WithInitializer(
        //        SyntaxFactory.InitializerExpression(
        //           SyntaxKind.ArrayInitializerExpression,
        //           [.. func(arrItems)]
        //        )
        //    );



        //}
        //public static ExpressionSyntax ArrayInitializerExpression<T>(T[]? items, Func<T[], IEnumerable<ExpressionSyntax>> func)
        //{
        //    var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName))
        //        .WithRankSpecifiers([
        //            SyntaxFactory.ArrayRankSpecifier([
        //                SyntaxFactory.OmittedArraySizeExpression()
        //            ])
        //        ]);

        //    if (items is null)
        //    {
        //        return SyntaxFactory.DefaultExpression(arrayType);
        //    }

        //    return
        //        SyntaxFactory.ArrayCreationExpression(arrayType)
        //        .WithInitializer(
        //           SyntaxFactory.InitializerExpression(
        //                SyntaxKind.ArrayInitializerExpression,
        //                [.. func(items)]
        //            )
        //        );
        //}
        public static ExpressionSyntax ArrayInitializerExpression<T>(T[]? items) where T : struct
        {
            var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName))
                 .WithRankSpecifiers([
                     SyntaxFactory.ArrayRankSpecifier([
                        SyntaxFactory.OmittedArraySizeExpression()
                    ])
                 ]);
            if (items is null)
            {
                return SyntaxFactory.DefaultExpression(arrayType);
            }

            var txt = items.ArrayDisplay();
            return SyntaxFactory.ParseExpression(txt);
        }
        public static ExpressionSyntax ArrayInitializerExpression<T>(T[]?[]? arrItems) where T : struct
        {
            var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName))
              .WithRankSpecifiers([
                  SyntaxFactory.ArrayRankSpecifier([
                                SyntaxFactory.OmittedArraySizeExpression()
                            ]),
                            SyntaxFactory.ArrayRankSpecifier([
                                SyntaxFactory.OmittedArraySizeExpression()
                            ])
              ]);

            if (arrItems is null)
            {
                return SyntaxFactory.DefaultExpression(arrayType);
            }
            var txt = $"[{string.Join(", ", arrItems.Select(p => ArrayInitializerExpression(p).NormalizeWhitespace().ToFullString()))}]";
            return SyntaxFactory.ParseExpression(txt);
        }

        public static PropertyDeclarationSyntax BuildClassMemberMetadataJson(ClassMemberMetadataData classMember)
        {
            var baseType = SyntaxFactory.ParseTypeName(typeof(MonoJsonClassDTO).FullName);
            var newData = SyntaxFactory.ObjectCreationExpression(baseType)
                .WithArgumentList(SyntaxFactory.ArgumentList(
                        [
                          SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(classMember.Code))),
                          SyntaxFactory.Argument(ArrayInitializerExpression(classMember.Utf8ImageName)),
                          SyntaxFactory.Argument(ArrayInitializerExpression(classMember.Utf8Namespace)),
                          SyntaxFactory.Argument(ArrayInitializerExpression(classMember.Utf8ClassName)),
                          SyntaxFactory.Argument(ArrayInitializerExpression(classMember.Utf8FullName)),
                        ]
                    )
                );
            var body = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(baseType, nameof(MonoJsonClassDTO))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithAccessorList(SyntaxFactory.AccessorList([body]))
                .WithInitializer(SyntaxFactory.EqualsValueClause(newData))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;
        }
        public static PropertyDeclarationSyntax BuildClassPropertyMetadataJson(ClassMemberMetadataData classMember)
        {
            var baseType = SyntaxFactory.ParseTypeName(typeof(MonoJsonFieldDTO).FullName);

            var arrayType = SyntaxFactory.ArrayType(baseType)
              .WithRankSpecifiers(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                SyntaxFactory.OmittedArraySizeExpression()))));


            var body = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(arrayType, nameof(MonoJsonFieldDTO))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithAccessorList(SyntaxFactory.AccessorList([body]))
                .WithInitializer(SyntaxFactory.EqualsValueClause(SyntaxFactory.ArrayCreationExpression(arrayType).WithInitializer
                (
                         SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression,
                                SyntaxFactory.SeparatedList<ExpressionSyntax>(
                                        EnumObjectCreationExpressionSyntax(classMember.PropertyMetadataDatas, baseType)
                                    )
                            )
                    )))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;

            static IEnumerable<ObjectCreationExpressionSyntax> EnumObjectCreationExpressionSyntax(ClassPropertyMetadataData[] propertyMetadataDatas, TypeSyntax typeSyntax)
            {
                foreach (var p in propertyMetadataDatas)
                {
                    yield return SyntaxFactory.ObjectCreationExpression(typeSyntax)
                     .WithArgumentList(SyntaxFactory.ArgumentList(
                             [
                                 SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(p.Code))),
                                SyntaxFactory.Argument(ArrayInitializerExpression(p.Utf8PropertyName)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(p.Utf8PropertyType)),
                                SyntaxFactory.Argument(p.PropertySymbol.IsStatic?SyntaxFactory.LiteralExpression(SyntaxKind.TrueLiteralExpression):
                                SyntaxFactory.LiteralExpression(SyntaxKind.FalseLiteralExpression)),
                             ]
                         )
                     );

                }
            }
        }
        public static PropertyDeclarationSyntax BuildClassMethodMetadataJson(ClassMemberMetadataData classMember)
        {
            var baseType = SyntaxFactory.ParseTypeName(typeof(MonoJsonMethodDTO).FullName);

            var arrayType = SyntaxFactory.ArrayType(baseType)
              .WithRankSpecifiers(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                SyntaxFactory.OmittedArraySizeExpression()))));


            var body = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(arrayType, nameof(MonoJsonMethodDTO))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithAccessorList(SyntaxFactory.AccessorList([body]))
                .WithInitializer(SyntaxFactory.EqualsValueClause(SyntaxFactory.ArrayCreationExpression(arrayType).WithInitializer
                (
                         SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression,
                                SyntaxFactory.SeparatedList<ExpressionSyntax>(
                                        EnumObjectCreationExpressionSyntax(classMember.MethodMetadataDatas, baseType)
                                    )
                            )
                    )))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;

            static IEnumerable<ObjectCreationExpressionSyntax> EnumObjectCreationExpressionSyntax(ClassMethodMetadataData[] methodMetadataDatas, TypeSyntax typeSyntax)
            {
                foreach (var m in methodMetadataDatas)
                {
                    yield return SyntaxFactory.ObjectCreationExpression(typeSyntax)
                     .WithArgumentList(SyntaxFactory.ArgumentList(
                             [
                                SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(m.Code))),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodName)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodParameterTypes)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodReturnType)),
                             ]
                         )
                     );

                }
            }

        }
        public static void BuildClassMetadataJson(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> members)
        {
            members.AddRange([
                BuildClassMemberMetadataJson(classMember),
                BuildClassPropertyMetadataJson(classMember),
                BuildClassMethodMetadataJson(classMember)
                ]);
        }
        #endregion




    }
}
