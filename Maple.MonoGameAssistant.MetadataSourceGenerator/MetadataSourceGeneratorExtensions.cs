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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public static class MetadataSourceGeneratorExtensions
    {

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
                    metadata.Utf8MethodParameterTypes = [.. EnumMethodParameterTypes(methodSymbol).OrderBy(p => p.order).Select(p => p.utf8Parameter)];
                    metadata.Code = MetadataSourceGeneratorCounter.Increment();

                    BuildMethodMemberExpression(ptrSymbol, metadata);
                    yield return metadata;
                }
            }

            static IEnumerable<(byte[]? utf8Parameter, int order)> EnumMethodParameterTypes(IMethodSymbol methodSymbol)
            {
                var attributeDatas = methodSymbol.GetAttributes().Where(p => p.AttributeClass is not null && p.AttributeClass.ToDisplayString() == typeof(ClassMethodParameterMetadataAttribute).FullName).ToArray();

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
        public static void BuildClassPartialPropertyExpression(this ClassMemberMetadataData classMember, List<FieldDeclarationSyntax> fields, List<ExpressionStatementSyntax> expressions, List<StructDeclarationSyntax> structs)
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


        public static void BuildMethodMemberExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod)
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
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                .WithParameterList(SyntaxFactory.ParameterList(
                            SyntaxFactory.SeparatedList(
                            [
                                ..EnumParameterSyntax(classMethod),
                            ])
                ))
                .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                    SyntaxFactory.InvocationExpression(
                          SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.ThisExpression(),
                            SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructMemberName())
                            )
                    ).WithArgumentList(SyntaxFactory.ArgumentList(
                        [
                            ..EnumArgumentSyntax(classMethod)
                        ]))
                ))
                .WithSemicolonToken(
                    SyntaxFactory.Token(SyntaxKind.SemicolonToken)
                    .WithLeadingTrivia(SyntaxFactory.LineFeed, SyntaxFactory.LineFeed)
                

                )



                .WithAttributeLists(
                [
                    SyntaxFactory.AttributeList(
                    [
                        NewAttribute<MethodImplAttribute,MethodImplOptions>(nameof(MethodImplOptions.AggressiveInlining))
                    ])
                ]);



            var operatorDeclaration = SyntaxFactory.ConversionOperatorDeclaration(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword), SyntaxFactory.ParseTypeName(classMethod.GetDelegatePointerStructName()))
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
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)));

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



            static FunctionPointerCallingConventionSyntax GetFunctionPointerCallingConvention(ClassMethodMetadataData classMethod)
            {
                if (classMethod.CallConvs is null)
                {
                    return SyntaxFactory.FunctionPointerCallingConvention(SyntaxFactory.Token(SyntaxKind.ManagedKeyword));
                }
                return
                    SyntaxFactory.FunctionPointerCallingConvention(
                          SyntaxFactory.Token(SyntaxKind.UnmanagedKeyword),
                          SyntaxFactory.FunctionPointerUnmanagedCallingConventionList(
                              SyntaxFactory.SeparatedList(
                              [
                                  ..EnumFunctionPointerUnmanagedCallingConventionSyntax(classMethod.CallConvs)
                              ])
                          )
                    );

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
        public static void BuildMethodInCtorExpression(this ClassMemberMetadataData classMember)
        {

        }


        public static void BuildPropertyInCtorExpression(this ClassMemberMetadataData classMember)
        {

        }
        #endregion




    }
}
