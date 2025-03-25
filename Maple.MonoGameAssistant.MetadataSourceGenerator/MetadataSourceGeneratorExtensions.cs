using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public static class MetadataSourceGeneratorExtensions
    {
        #region Helper

        internal static AttributeSyntax NewAttribute<T_Attribute, T_ARG>(string value) where T_Attribute : Attribute
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
        static byte[]? GetUtf8Bytes(this string? txt)
        {
            if (txt is null)
            {
                return default;
            }
            else if (txt.Length == 0)
            {
                return [];
            }
            else
            {
                return Encoding.UTF8.GetBytes(txt);
            }
        }
        static string ArrayDisplay<T>(this IEnumerable<T> arr)
            where T : struct
        {
            return $@"[{string.Join(", ", arr)}]";
        }

        static bool TryGetAttributeBytes_CtorArgs(this AttributeData attributeData, int index, out byte[]? bytes)
        {
            Unsafe.SkipInit(out bytes);
            if (attributeData.TryGetAttributeValue_CtorArgs(index, out ImmutableArray<TypedConstant> arrVal) && arrVal.TryReadImmutableArray(out bytes))
            {
                return true;
            }
            else if (attributeData.TryGetAttributeValue_CtorArgs(index, out string? txt))
            {
                bytes = GetUtf8Bytes(txt);
                return true;
            }
            return false;
        }
        #endregion

        #region Common

        static SyntaxToken ConvertToHexLiteral(ulong value)
        {
            string hexString = $"0x{value:X}UL";
            return SyntaxFactory.Literal(hexString, value);
        }
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

        [Obsolete("remove...")]
        public static MemberDeclarationSyntax BuildDerivedLoadMetadata(ClassMemberMetadataData classMember)
        {

            var typeSyntax = SyntaxFactory.ParseTypeName(classMember.ContextSymbol.ToDisplayString());
            var argSyntax = SyntaxFactory.Parameter(SyntaxFactory.Identifier($"@{SyntaxFactory.ThisExpression().ToFullString()}")).WithType(SyntaxFactory.ParseTypeName(classMember.PtrSymbol.ToDisplayString()));



            return
                    SyntaxFactory.MethodDeclaration(typeSyntax, classMember.MethodName_LoadMetadata)
                    .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                    .WithParameterList(SyntaxFactory.ParameterList([
                         argSyntax
                    ]))
                    .WithExpressionBody(
                        CallExpression()
                    )
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));


            ArrowExpressionClauseSyntax CallExpression()
            {
                //    SyntaxFactory.Identifier($"@{SyntaxFactory.ThisExpression().ToFullString()}")
                var lambdaParameter = SyntaxFactory.Parameter(SyntaxFactory.Identifier("p"));
                var lambdaBody = SyntaxFactory.ObjectCreationExpression(typeSyntax)
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            [SyntaxFactory.Argument(SyntaxFactory.IdentifierName("p"))]
                            ));


                var lambdaExpression = SyntaxFactory.SimpleLambdaExpression(
                    lambdaParameter,
                    lambdaBody).WithModifiers([SyntaxFactory.Token(SyntaxKind.StaticKeyword)]);

                return SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.InvocationExpression(
                          SyntaxFactory.MemberAccessExpression(
                                  SyntaxKind.SimpleMemberAccessExpression,
                                  SyntaxFactory.IdentifierName(classMember.ContextSymbol.ToDisplayString()),
                                  SyntaxFactory.IdentifierName(classMember.MethodName_LoadMetadata)
                                  )
                            ).WithArgumentList(
                                SyntaxFactory.ArgumentList(
                                    [
                                        SyntaxFactory.Argument(SyntaxFactory.IdentifierName($"@{SyntaxFactory.ThisExpression().ToFullString()}")),
                                        SyntaxFactory.Argument(lambdaExpression)
                                    ]
                                   )));
            }

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

        public static ClassDeclarationSyntax CreateGenericClassDeclarationSyntaxExpression(
            GenericClassMemberMetadataData metadataData,
            SyntaxList<MemberDeclarationSyntax> memberDeclarations)
        {
            //        var derivedClassFullName = metadataData.ContextSymbol.ToDisplayString();
            var derivedClassName = SyntaxFactory.GenericName(SyntaxFactory.Identifier(metadataData.ContextSymbol.Name),
                SyntaxFactory.TypeArgumentList([.. EnumTypeSyntax()]));


            var genericName = SyntaxFactory.MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                SyntaxFactory.IdentifierName(metadataData.ParentSymbol.ContainingNamespace.ToDisplayString()),
                SyntaxFactory.IdentifierName(metadataData.ParentSymbol.Name));

            var derivedClass = SyntaxFactory.ClassDeclaration(derivedClassName.ToFullString());
            var baseClass = SyntaxFactory.GenericName(SyntaxFactory.Identifier(genericName.ToFullString()), SyntaxFactory.TypeArgumentList(
                [
       //             SyntaxFactory.ParseTypeName(derivedClassFullName),
                    SyntaxFactory.ParseTypeName(metadataData.PtrSymbol.ToDisplayString())
                ]));
            var classDeclaration = derivedClass
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithBaseList(SyntaxFactory.BaseList([SyntaxFactory.SimpleBaseType(baseClass)]))
                .WithMembers(memberDeclarations);
            return classDeclaration;

            IEnumerable<TypeSyntax> EnumTypeSyntax()
            {
                foreach (var type in metadataData.TypeSymbols)
                {
                    yield return SyntaxFactory.ParseTypeName(type.Name);

                }
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

            //static IEnumerable<SyntaxToken> EnumModifiers(ISymbol symbol)
            //{
            //    if (symbol is not INamedTypeSymbol namedTypeSymbol || namedTypeSymbol.IsValueType == false)
            //    {
            //        yield break;
            //    }

            //    if (namedTypeSymbol.DeclaredAccessibility == Accessibility.Public)
            //    {
            //        yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
            //    }
            //    else if (namedTypeSymbol.DeclaredAccessibility == Accessibility.Internal)
            //    {
            //        yield return SyntaxFactory.Token(SyntaxKind.InternalKeyword);
            //    }
            //    else if (namedTypeSymbol.DeclaredAccessibility == Accessibility.Private)
            //    {
            //        yield return SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
            //    }

            //    if (namedTypeSymbol.IsReadOnly)
            //    {
            //        yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
            //    }

            //}
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
                               )
                           );
                    }
                    else
                    {
                        yield return
                          SyntaxFactory.ExpressionElement(
                              SyntaxFactory.MemberAccessExpression(
                                  SyntaxKind.SimpleMemberAccessExpression,
                                  SyntaxFactory.IdentifierName(symbol.ToDisplayString()),
                                  SyntaxFactory.IdentifierName(name)
                              )
                          );
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

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(baseType, "ApiVersion")
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.OverrideKeyword)])
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
                    parameter = parameter.WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, ConvertToHexLiteral(code))));
                }
                yield return parameter;
            }
        }

        public static IEnumerable<ParameterSyntax> BuildGenericClassParentCtorParameterExpression(IEnumerable<IParameterSymbol> parameterSymbols)
        {
            foreach (var arg in parameterSymbols)
            {
                var parameter = SyntaxFactory.Parameter(SyntaxFactory.Identifier(arg.Name))
                           .WithType(SyntaxFactory.ParseTypeName(arg.Type.ToDisplayString()));
                yield return parameter;
            }
        }


        #endregion

        #region ClassMemberMetadataData
        private static ulong GetClassCode(string classDisplayString)
        {
            if (false == MetadataSourceGeneratorHashAlgorithm.TryGetClassHash(classDisplayString, out var classHash, out var oldclassDisplayName))
            {
                return MetadataSourceGeneratorException.Throw<ulong>($"{classDisplayString} hash already exists:{oldclassDisplayName}");
            }
            return classHash;
        }
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

            var classDisplayString = ctx.TargetSymbol.ToDisplayString();
            var metadata = new ClassMemberMetadataData()
            {
                Code = GetClassCode(classDisplayString),
                ParentSymbol = parentMetadata.AttributeClass.TypeArguments[0],
                PtrSymbol = ptrSymbol,

                ContextSymbol = ctx.TargetSymbol,

                PropertyMetadataDatas = [.. ptrSymbol.EnumClassPropertyMetadata().OrderBy(p => p.PropertySymbol.IsStatic ? 1 : 0)],
                MethodMetadataDatas = [.. ptrSymbol.EnumClassMethodMetadata().OrderBy(p => p.RuntimeMethod ? 1 : 0)]
            };

            if (att.TryGetAttributeBytes_CtorArgs(0, out byte[]? utf8ImageName))
            {
                metadata.Utf8ImageName = utf8ImageName;
            }
            if (att.TryGetAttributeBytes_CtorArgs(1, out byte[]? utf8Namespace))
            {
                metadata.Utf8Namespace = utf8Namespace;
            }
            if (att.TryGetAttributeBytes_CtorArgs(2, out byte[]? utf8ClassName))
            {
                metadata.Utf8ClassName = utf8ClassName;
            }
            if (att.TryGetAttributeBytes_CtorArgs(3, out byte[]? utf8FullName))
            {
                metadata.Utf8FullName = utf8FullName;
            }
            //  if(ctx.)
            return metadata;

        }
        public static GenericClassMemberMetadataData GetGenericClassMemberMetadataData(this GeneratorAttributeSyntaxContext ctx, AttributeData att)
        {
            var typeSymbols = (ctx.TargetSymbol as INamedTypeSymbol)?.TypeParameters ?? [];
            if (typeSymbols.Length == 0)
            {
                return MetadataSourceGeneratorException.Throw<GenericClassMemberMetadataData>($"{ctx.TargetSymbol.ToDisplayString()} type error");
            }
            var parentMetadata = ctx.TargetSymbol.GetAttributes().Where(p =>
              p.AttributeClass!.ContainingNamespace.ToDisplayString() == typeof(GenericClassParentMetadataAttribute).Namespace
              && p.AttributeClass.MetadataName == typeof(GenericClassParentMetadataAttribute).Name
              ).FirstOrDefault();
            if (parentMetadata is null)
            {
                return MetadataSourceGeneratorException.Throw<GenericClassMemberMetadataData>($"{ctx.TargetSymbol.ToDisplayString()} not found {typeof(GenericClassParentMetadataAttribute).FullName}");
            }
            if (!parentMetadata.ConstructorArguments.Any()
                || (!parentMetadata.TryGetAttributeValue_CtorArgs(0, out INamedTypeSymbol? parentSymbol) || parentSymbol is null)
                || (!parentMetadata.TryGetAttributeValue_CtorArgs(1, out INamedTypeSymbol? ptrSymbol) || ptrSymbol is null)
                )
            {
                return MetadataSourceGeneratorException.Throw<GenericClassMemberMetadataData>($"{ctx.TargetSymbol.ToDisplayString()} args error {typeof(GenericClassParentMetadataAttribute).FullName}");
            }



            //      var ptrSymbol = parentMetadata.AttributeClass!.TypeArguments[1];

            var classDisplayString = ctx.TargetSymbol.ToDisplayString();
            var metadata = new GenericClassMemberMetadataData()
            {
                Code = GetClassCode(classDisplayString),
                ParentSymbol = parentSymbol.OriginalDefinition,
                PtrSymbol = ptrSymbol.OriginalDefinition,

                ContextSymbol = ctx.TargetSymbol,
                TypeSymbols = [.. typeSymbols],
                PropertyMetadataDatas = [.. ptrSymbol.OriginalDefinition.EnumClassPropertyMetadata().OrderBy(p => p.PropertySymbol.IsStatic ? 1 : 0)],
                MethodMetadataDatas = [.. ptrSymbol.OriginalDefinition.EnumClassMethodMetadata().OrderBy(p => p.RuntimeMethod ? 1 : 0)]
            };

            //if (att.TryGetAttributeBytes_CtorArgs(0, out byte[]? utf8ImageName))
            //{
            //    metadata.Utf8ImageName = utf8ImageName;
            //}
            //if (att.TryGetAttributeBytes_CtorArgs(1, out byte[]? utf8Namespace))
            //{
            //    metadata.Utf8Namespace = utf8Namespace;
            //}
            //if (att.TryGetAttributeBytes_CtorArgs(2, out byte[]? utf8ClassName))
            //{
            //    metadata.Utf8ClassName = utf8ClassName;
            //}
            //if (att.TryGetAttributeBytes_CtorArgs(3, out byte[]? utf8FullName))
            //{
            //    metadata.Utf8FullName = utf8FullName;
            //}
            //  if(ctx.)
            return metadata;

        }

        private static ulong GetPropertyCode(string fieldDisplayString)
        {

            if (false == MetadataSourceGeneratorHashAlgorithm.TryGetFieldHash(fieldDisplayString, out var fieldHash, out var oldFieldDisplayName))
            {
                return MetadataSourceGeneratorException.Throw<ulong>($"{fieldDisplayString} hash already exists:{oldFieldDisplayName}");
            }
            return fieldHash;
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
                    if (att.TryGetAttributeBytes_CtorArgs(0, out byte[]? utf8Name))
                    {
                        metadata.Utf8PropertyName = utf8Name;
                    }
                    if (att.TryGetAttributeBytes_CtorArgs(1, out byte[]? utf8Type))
                    {
                        metadata.Utf8PropertyType = utf8Type;
                    }

                    metadata.Code = GetPropertyCode(propertySymbol.ToDisplayString());

                    yield return metadata;
                }
            }

        }

        private static ulong GetMethodCode(string methodDisplayString)
        {

            if (false == MetadataSourceGeneratorHashAlgorithm.TryGetFieldHash(methodDisplayString, out var methodHash, out var oldMethodDisplayName))
            {
                return MetadataSourceGeneratorException.Throw<ulong>($"{methodDisplayString} hash already exists:{oldMethodDisplayName}");
            }
            return methodHash;
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
                    if (att.TryGetAttributeBytes_CtorArgs(0, out byte[]? utf8Name))
                    {
                        metadata.Utf8MethodName = utf8Name;
                    }

                    if (att.TryGetAttributeBytes_CtorArgs(1, out byte[]? utf8Type))
                    {
                        metadata.Utf8MethodReturnType = utf8Type;
                    }

                    metadata.RuntimeMethod = att.GetAttributeValue_NamedArgs(nameof(ClassMethodMetadataAttribute.RuntimeMethodAsThis), false);

                    var callTypes = att.GetAttributeValue_NamedArgs<ImmutableArray<TypedConstant>>(nameof(ClassMethodMetadataAttribute.CallConvs), []);
                    if (callTypes.TryReadImmutableArray<ISymbol>(out var callConvs))
                    {
                        metadata.CallConvs = callConvs;
                    }

                    if (TryEnumMethodParameterTypes(metadata.MethodSymbol, out var parameterTypes))
                    {
                        metadata.Utf8MethodParameterTypes = parameterTypes;
                    }

                    metadata.Code = GetMethodCode(methodSymbol.ToDisplayString());

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
                        if (att.TryGetAttributeBytes_CtorArgs(0, out byte[]? utf8Parameter))
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
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, ConvertToHexLiteral(classProperty.Code)))
                                ]
                                ))
                        )
                    );



        }

        public static PropertyDeclarationSyntax BuildPartialPropertyMemberExpression(ISymbol contextSymbol, ClassPropertyMetadataData classProperty)
        {
            var baseType = SyntaxFactory.ParseTypeName(classProperty.PropertySymbol.Type.ToDisplayString());
            var propType = baseType;
            var refKind = false;
            if (classProperty.PropertySymbol.IsStatic == false)
            {
                if (classProperty.PropertySymbol.RefKind == RefKind.Ref)
                {
                    propType = SyntaxFactory.RefType(propType);
                    refKind = true;
                }
                else if (classProperty.PropertySymbol.RefKind == RefKind.RefReadOnly)
                {
                    propType = SyntaxFactory.RefType(propType).WithReadOnlyKeyword(SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword));
                    refKind = true;
                }
            }

            var classfullName = SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString());

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(propType, classProperty.PropertySymbol.Name)
                .WithModifiers([.. EnumModifiers(classProperty)])
                .WithAccessorList(
                    SyntaxFactory.AccessorList([.. EnumAccessorDeclarationSyntax(classfullName, baseType, classProperty, refKind)])
                 );

            //      var content = propertyDeclaration.NormalizeWhitespace().ToFullString();

            return propertyDeclaration;



            static IEnumerable<SyntaxToken> EnumModifiers(ClassPropertyMetadataData classProperty)
            {
                if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Public)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                }
                else if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Internal)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.InternalKeyword);
                }
                else if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Private)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
                }


                if (classProperty.PropertySymbol.IsStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                }
                //if (classProperty.PropertySymbol.IsReadOnly)
                //{
                //    yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                //}
                if (classProperty.PropertySymbol.IsPartialDefinition)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                }
            }

            static IEnumerable<AccessorDeclarationSyntax> EnumAccessorDeclarationSyntax(
                IdentifierNameSyntax classfullName,
                TypeSyntax propType,
                ClassPropertyMetadataData classProperty,
                bool refKind)
            {
                ExpressionSyntax? getAccessorBody = null;
                ExpressionSyntax? setAccessorBody = null;

                if (classProperty.PropertySymbol.IsStatic)
                {

                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        getAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                )
                            )
                           .WithArgumentList(
                               SyntaxFactory.ArgumentList([
                                   SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                             SyntaxKind.SimpleMemberAccessExpression,
                                             classfullName,
                                             SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )
                                    )
                               ])
                           );

                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        setAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                ),
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            classfullName,
                                            SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )),
                                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")).WithRefKindKeyword( SyntaxFactory.Token(SyntaxKind.InKeyword))
                                ])
                            );
                    }
                }
                else
                {
                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        getAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetMemberFieldValue)))
                                        .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                )
                            )
                            .WithArgumentList(
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            classfullName,
                                            SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )
                                    )
                                ])
                            );
                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        setAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetMemberFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                ),
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                      SyntaxFactory.Argument(
                                          SyntaxFactory.MemberAccessExpression(
                                              SyntaxKind.SimpleMemberAccessExpression,
                                              classfullName,
                                              SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                          )
                                      ),
                                      SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")).WithRefKindKeyword(SyntaxFactory.Token(SyntaxKind.InKeyword))
                                ])
                            );
                    }
                }



                if (getAccessorBody is not null)
                {
                    if (refKind)
                    {
                        getAccessorBody = SyntaxFactory.RefExpression(getAccessorBody);
                    }
                    yield return
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithBody(
                            SyntaxFactory.Block(
                                SyntaxFactory.ReturnStatement(
                                    getAccessorBody
                                )
                            )
                        );
                }
                if (setAccessorBody is not null)
                {
                    yield return
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithBody(
                            SyntaxFactory.Block(
                                SyntaxFactory.ExpressionStatement(
                                    setAccessorBody
                                )
                            )
                        );
                }
            }
        }

        public static void BuildClassPartialPropertyExpression(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> fields, List<ExpressionStatementSyntax> expressions, List<StructDeclarationSyntax> structs)
        {
            if (classMember.PropertyMetadataDatas.Length == 0)
            {
                return;
            }
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



        [Obsolete("remove...")]
        public static FieldDeclarationSyntax GenericBuildOffsetMemberExpression(ClassPropertyMetadataData classProperty)
        {
            VariableDeclarationSyntax variableDeclaration =
                classProperty.PropertySymbol.IsStatic ?
                SyntaxFactory.VariableDeclaration(
                   SyntaxFactory.IdentifierName(typeof(MonoStaticFieldSource).FullName),
                   [SyntaxFactory.VariableDeclarator(classProperty.GetOffsetVariableName())])
                : SyntaxFactory.VariableDeclaration(
                       SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)),
                   [SyntaxFactory.VariableDeclarator(classProperty.GetOffsetVariableName())]);
            return SyntaxFactory.FieldDeclaration(variableDeclaration);
        }

        public static ExpressionStatementSyntax GenericAssignmentOffsetMemberExpression(ISymbol contextSymbol, ClassPropertyMetadataData classProperty)
        {
            var callMethod = classProperty.PropertySymbol.IsStatic
                ? nameof(IGenericClassMetadataCollector.GetStaticFieldMetadata)
                : nameof(IGenericClassMetadataCollector.GetMemberFieldOffset);
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
                                     // SyntaxFactory.Argument(SyntaxFactory.IdentifierName(classProperty.GetDescVariableName()))
                                     SyntaxFactory.Argument( SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()), SyntaxFactory.IdentifierName(classProperty.GetDescVariableName())))
                                ]
                                ))
                        )
                    );



        }
        [Obsolete("remove...")]
        public static PropertyDeclarationSyntax GenericBuildPartialPropertyMemberExpression(ClassMemberMetadataData classMember, ClassPropertyMetadataData classProperty)
        {
            var baseType = SyntaxFactory.ParseTypeName(classProperty.PropertySymbol.Type.ToDisplayString());
            var propType = baseType;
            var refKind = false;
            if (classProperty.PropertySymbol.IsStatic == false)
            {
                if (classProperty.PropertySymbol.RefKind == RefKind.Ref)
                {
                    propType = SyntaxFactory.RefType(propType);
                    refKind = true;
                }
                else if (classProperty.PropertySymbol.RefKind == RefKind.RefReadOnly)
                {
                    propType = SyntaxFactory.RefType(propType).WithReadOnlyKeyword(SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword));
                    refKind = true;
                }
            }
            ISymbol contextSymbol = classMember.ContextSymbol;
            var classfullName = SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString());


            var callLoadMetadata = SyntaxFactory.InvocationExpression(
                           SyntaxFactory.MemberAccessExpression(
                              SyntaxKind.SimpleMemberAccessExpression,
                              SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()),
                              SyntaxFactory.IdentifierName(classMember.MethodName_LoadMetadata)
                              )).WithArgumentList(SyntaxFactory.ArgumentList([
                                   SyntaxFactory.Argument( SyntaxFactory.ThisExpression())
                                  ]));



            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(propType, classProperty.PropertySymbol.Name)
                .WithModifiers([.. EnumModifiers(classProperty)])
                .WithAccessorList(
                    SyntaxFactory.AccessorList([.. EnumAccessorDeclarationSyntax(classfullName, callLoadMetadata, baseType, classProperty, refKind)])
                 );

            //      var content = propertyDeclaration.NormalizeWhitespace().ToFullString();

            return propertyDeclaration;



            static IEnumerable<SyntaxToken> EnumModifiers(ClassPropertyMetadataData classProperty)
            {
                if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Public)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                }
                else if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Internal)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.InternalKeyword);
                }
                else if (classProperty.PropertySymbol.DeclaredAccessibility == Accessibility.Private)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
                }


                if (classProperty.PropertySymbol.IsStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                }
                //if (classProperty.PropertySymbol.IsReadOnly)
                //{
                //    yield return SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
                //}
                if (classProperty.PropertySymbol.IsPartialDefinition)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                }
            }

            static IEnumerable<AccessorDeclarationSyntax> EnumAccessorDeclarationSyntax(
                IdentifierNameSyntax classfullName,
                ExpressionSyntax callLoadMetadata,
                TypeSyntax propType,
                ClassPropertyMetadataData classProperty,
                bool refKind)
            {
                ExpressionSyntax? getAccessorBody = null;
                ExpressionSyntax? setAccessorBody = null;

                if (classProperty.PropertySymbol.IsStatic)
                {

                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        getAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                )
                            )
                           .WithArgumentList(
                               SyntaxFactory.ArgumentList([
                                   SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                             SyntaxKind.SimpleMemberAccessExpression,
                                             callLoadMetadata,
                                             SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )
                                    )
                               ])
                           );

                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        setAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetStaticFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                ),
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            callLoadMetadata,
                                            SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )),
                                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")).WithRefKindKeyword( SyntaxFactory.Token(SyntaxKind.InKeyword))
                                ])
                            );
                    }
                }
                else
                {
                    if (classProperty.PropertySymbol.GetMethod is not null)
                    {
                        getAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.GetMemberFieldValue)))
                                        .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                )
                            )
                            .WithArgumentList(
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            callLoadMetadata,
                                            SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                        )
                                    )
                                ])
                            );
                    }
                    if (classProperty.PropertySymbol.SetMethod is not null)
                    {
                        setAccessorBody =
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    classfullName,
                                    SyntaxFactory.GenericName(SyntaxFactory.Identifier(nameof(IClassMetadataCollector.SetMemberFieldValue))).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([propType]))
                                ),
                                SyntaxFactory.ArgumentList([
                                    SyntaxFactory.Argument(SyntaxFactory.ThisExpression()),
                                      SyntaxFactory.Argument(
                                          SyntaxFactory.MemberAccessExpression(
                                              SyntaxKind.SimpleMemberAccessExpression,
                                              callLoadMetadata,
                                              SyntaxFactory.IdentifierName(classProperty.GetOffsetVariableName())
                                          )
                                      ),
                                      SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")).WithRefKindKeyword(SyntaxFactory.Token(SyntaxKind.InKeyword))
                                ])
                            );
                    }
                }



                if (getAccessorBody is not null)
                {
                    if (refKind)
                    {
                        getAccessorBody = SyntaxFactory.RefExpression(getAccessorBody);
                    }
                    yield return
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithBody(
                            SyntaxFactory.Block(
                                SyntaxFactory.ReturnStatement(
                                    getAccessorBody
                                )
                            )
                        );
                }
                if (setAccessorBody is not null)
                {
                    yield return
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithBody(
                            SyntaxFactory.Block(
                                SyntaxFactory.ExpressionStatement(
                                    setAccessorBody
                                )
                            )
                        );
                }
            }
        }

        public static void BuildGenericClassPartialPropertyExpression(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> fields, List<ExpressionStatementSyntax> expressions, List<StructDeclarationSyntax> structs)
        {
            if (classMember.PropertyMetadataDatas.Length == 0)
            {
                return;
            }
            var propertyDeclarations = new List<PropertyDeclarationSyntax>();
            foreach (var member in classMember.PropertyMetadataDatas)
            {
                var f = BuildOffsetMemberExpression(member);
                fields.Add(f);

                var s = GenericAssignmentOffsetMemberExpression(classMember.ContextSymbol, member);
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
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, ConvertToHexLiteral(classMethod.Code)))
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
            if (classMember.MethodMetadataDatas.Length == 0)
            {
                return;
            }
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


        [Obsolete("remove...")]
        public static FieldDeclarationSyntax GenericBuildMethodMemberFieldExpression(ClassMethodMetadataData classMethod, StructDeclarationSyntax functionPointer)
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

            return SyntaxFactory.FieldDeclaration(variableDeclaration);

        }

        public static ExpressionStatementSyntax GenericAssignmentMethodMemberExpression(ISymbol contextSymbol, ClassMethodMetadataData classMethod, StructDeclarationSyntax functionPointer)
        {
            var callMethod = SyntaxFactory.MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    SyntaxFactory.ThisExpression(),
                    (
                        classMethod.RuntimeMethod ?
                        SyntaxFactory.GenericName(nameof(IGenericClassMetadataCollector.GetMethodDelegate))
                        .WithTypeArgumentList(SyntaxFactory.TypeArgumentList([SyntaxFactory.ParseTypeName(functionPointer.Identifier.Text)]))
                        : SyntaxFactory.IdentifierName(nameof(IGenericClassMetadataCollector.GetMethodPointer))
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
                                    SyntaxFactory.Argument( SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()), SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerDescName())))
                                ]
                                ))
                        )
                    );


        }
        [Obsolete("remove...")]
        public static MemberDeclarationSyntax GenericBuildMethodMemberCallExpression(ClassMemberMetadataData classMember, ClassMethodMetadataData classMethod)
        {
            //    var contextSymbol = classMember.ContextSymbol;
            return
                SyntaxFactory.MethodDeclaration(GetReturnSyntax(classMethod), classMethod.MethodSymbol.Name)
                .WithModifiers([.. EnumModifiers(classMethod)])
                .WithParameterList(SyntaxFactory.ParameterList([
                    ..EnumParameterSyntax(classMethod)
                ]))
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(GetBodyExpression(classMember, classMethod))
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            [Obsolete("remove...")]
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
            [Obsolete("remove...")]
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
            [Obsolete("remove...")]
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
            [Obsolete("remove...")]
            static InvocationExpressionSyntax GetInvocationExpression(ClassMemberMetadataData classMember, ClassMethodMetadataData classMethod)
            {
                ISymbol contextSymbol = classMember.ContextSymbol;
                var callLoadMetadata = SyntaxFactory.InvocationExpression(
                               SyntaxFactory.MemberAccessExpression(
                                  SyntaxKind.SimpleMemberAccessExpression,
                                  SyntaxFactory.IdentifierName(contextSymbol.ToDisplayString()),
                                  SyntaxFactory.IdentifierName(classMember.MethodName_LoadMetadata)
                                  )).WithArgumentList(SyntaxFactory.ArgumentList([
                                       SyntaxFactory.Argument( SyntaxFactory.ThisExpression())
                                      ]));





                //NAMESPACE.CLASS.LOADMETA(this).Field
                if (classMethod.RuntimeMethod)
                {
                    return MetadataSourceGeneratorException.Throw<InvocationExpressionSyntax>($"RuntimeMethod 暂未实现");

                    ////DemoGameSystem.s_Delegate_GetGlod_0.f.GetDelegatePointerStructCaller
                    //return
                    //SyntaxFactory.InvocationExpression(
                    //    SyntaxFactory.MemberAccessExpression(
                    //        SyntaxKind.SimpleMemberAccessExpression,
                    //        SyntaxFactory.MemberAccessExpression(
                    //            SyntaxKind.SimpleMemberAccessExpression,
                    //            SyntaxFactory.MemberAccessExpression(
                    //                SyntaxKind.SimpleMemberAccessExpression,
                    //                callLoadMetadata,
                    //                SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())
                    //            ),
                    //            SyntaxFactory.IdentifierName(nameof(MonoMethodDelegate<>.MethodPointer))
                    //        ),
                    //        SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCaller())
                    //    )
                    //);
                }

                return
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            callLoadMetadata,
                            SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStaticFieldName())
                        ),
                        SyntaxFactory.IdentifierName(classMethod.GetDelegatePointerStructCaller())
                    )
                );

            }
            [Obsolete("remove...")]
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

            [Obsolete("remove...")]
            static ExpressionSyntax GetBodyExpression(ClassMemberMetadataData classMember, ClassMethodMetadataData classMethod)
            {
                var contextSymbol = classMember.ContextSymbol;
                var baseBody = GetInvocationExpression(classMember, classMethod)
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

        public static void BuildGenericClassPartialMethodExpression(this ClassMemberMetadataData classMember,
            List<StructDeclarationSyntax> structs,
            List<MemberDeclarationSyntax> fields,
            List<ExpressionStatementSyntax> expressions)
        {

            if (classMember.MethodMetadataDatas.Length == 0)
            {
                return;
            }
            List<MemberDeclarationSyntax> members = [];
            foreach (var member in classMember.MethodMetadataDatas)
            {
                var s = BuildMethodMemberPointerExpression(member);
                structs.Add(s);

                var f = BuildMethodMemberFieldExpression(member, s);
                fields.Add(f);

                var e = GenericAssignmentMethodMemberExpression(classMember.ContextSymbol, member, s);
                expressions.Add(e);

                var m = BuildMethodMemberCallExpression(classMember.ContextSymbol, member);
                members.Add(m);
            }
            var ptr = CreateStructDeclarationSyntaxExpression(classMember.PtrSymbol, [.. members]);
            structs.Add(ptr);

        }



        public static ExpressionSyntax ArrayInitializerExpression<T>(T[]? items) where T : struct
        {

            if (items is null)
            {
                return SyntaxFactory.LiteralExpression(SyntaxKind.DefaultLiteralExpression);

                //           return SyntaxFactory.DefaultExpression(arrayType);
            }

            var txt = items.ArrayDisplay();
            return SyntaxFactory.ParseExpression(txt);
        }
        public static ExpressionSyntax ArrayInitializerExpression<T>(T[]?[]? arrItems) where T : struct
        {


            if (arrItems is null)
            {
                return SyntaxFactory.LiteralExpression(SyntaxKind.DefaultLiteralExpression);

                //       return SyntaxFactory.DefaultExpression(arrayType);
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
                          SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, ConvertToHexLiteral(classMember.Code))),
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

        }
        static IEnumerable<ObjectCreationExpressionSyntax> EnumObjectCreationExpressionSyntax(ClassPropertyMetadataData[] propertyMetadataDatas, TypeSyntax typeSyntax)
        {
            foreach (var p in propertyMetadataDatas)
            {
                yield return GetObjectCreationExpressionSyntax(p, typeSyntax);
            }
        }
        static ObjectCreationExpressionSyntax GetObjectCreationExpressionSyntax(ClassPropertyMetadataData p, TypeSyntax typeSyntax)
        {
            return SyntaxFactory.ObjectCreationExpression(typeSyntax)
                  .WithArgumentList(SyntaxFactory.ArgumentList(
                          [
                              SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, ConvertToHexLiteral(p.Code))),
                                SyntaxFactory.Argument(ArrayInitializerExpression(p.Utf8PropertyName)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(p.Utf8PropertyType)),
                                SyntaxFactory.Argument(p.PropertySymbol.IsStatic?SyntaxFactory.LiteralExpression(SyntaxKind.TrueLiteralExpression):
                                SyntaxFactory.LiteralExpression(SyntaxKind.FalseLiteralExpression)),
                          ]
                      )
                  );
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


        }
        static IEnumerable<ObjectCreationExpressionSyntax> EnumObjectCreationExpressionSyntax(ClassMethodMetadataData[] methodMetadataDatas, TypeSyntax typeSyntax)
        {
            foreach (var m in methodMetadataDatas)
            {
                yield return GetObjectCreationExpressionSyntax(m, typeSyntax);
            }
        }
        static ObjectCreationExpressionSyntax GetObjectCreationExpressionSyntax(ClassMethodMetadataData m, TypeSyntax typeSyntax)
        {
            return SyntaxFactory.ObjectCreationExpression(typeSyntax)
                 .WithArgumentList(SyntaxFactory.ArgumentList(
                         [
                            SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression,ConvertToHexLiteral(m.Code))),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodName)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodParameterTypes)),
                                SyntaxFactory.Argument(ArrayInitializerExpression(m.Utf8MethodReturnType)),
                         ]
                     )
                 );
        }

        public static void BuildClassMetadataJson(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> members)
        {
            members.AddRange([
                BuildClassMemberMetadataJson(classMember),
                BuildClassPropertyMetadataJson(classMember),
                BuildClassMethodMetadataJson(classMember)
                ]);
        }


        #region GenericClass
        static PropertyDeclarationSyntax CreateMemberDeclarationSyntax(TypeSyntax typeSyntax, string name, ObjectCreationExpressionSyntax newData)
        {
            var body = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(typeSyntax, name)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.StaticKeyword)])
                .WithAccessorList(SyntaxFactory.AccessorList([body]))
                .WithInitializer(SyntaxFactory.EqualsValueClause(newData))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            return propertyDeclaration;
        }

        public static IEnumerable<PropertyDeclarationSyntax> BuildGenericClassPropertyMetadataJson(ClassMemberMetadataData classMember)
        {
            var baseType = SyntaxFactory.ParseTypeName(typeof(MonoJsonFieldDTO).FullName);

            foreach (var p in classMember.PropertyMetadataDatas)
            {
                var newData = GetObjectCreationExpressionSyntax(p, baseType);
                yield return CreateMemberDeclarationSyntax(baseType, p.GetDescVariableName(), newData);
            }

        }
        public static IEnumerable<PropertyDeclarationSyntax> BuildGenericClassMethodMetadataJson(ClassMemberMetadataData classMember)
        {
            var baseType = SyntaxFactory.ParseTypeName(typeof(MonoJsonMethodDTO).FullName);
            foreach (var p in classMember.MethodMetadataDatas)
            {
                var newData = GetObjectCreationExpressionSyntax(p, baseType);
                yield return CreateMemberDeclarationSyntax(baseType, p.GetDelegatePointerDescName(), newData);
            }
        }


        public static void BuildGenericClassMetadataJson(this ClassMemberMetadataData classMember, List<MemberDeclarationSyntax> members)
        {
            members.AddRange([
              ..  BuildGenericClassPropertyMetadataJson(classMember),
              ..  BuildGenericClassMethodMetadataJson(classMember)
                ]);
        }

        #endregion


        #endregion




    }
}
