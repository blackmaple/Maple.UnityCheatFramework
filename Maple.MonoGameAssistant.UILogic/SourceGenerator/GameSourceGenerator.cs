using Maple.MonoGameAssistant.Model;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maple.MonoGameAssistant.MonoCollector;
using System.Runtime.InteropServices;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Text.Json;
using System.Security.AccessControl;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.MonoGameAssistant.UILogic
{
    public static class GameSourceGeneratorFactory
    {

        static NamespaceDeclarationSyntax BuildNamespaceExpression(string containingNamespace, params ClassDeclarationSyntax[] classDeclarationSyntaxes)
        {
            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(containingNamespace))
                .WithMembers([.. classDeclarationSyntaxes]);
        }

        public static NamespaceDeclarationSyntax BuildNamespaceDeclarationSyntax(GameClassInfo gameClassInfo, string containingNamespace)
        {
            List<PropertyDeclarationSyntax> propertyDeclarationSyntaxes = [];
            List<MethodDeclarationSyntax> methodDeclarationSyntaxes = [];
            List<InterfaceDeclarationSyntax> interfaceDeclarations = [];
            List<StructDeclarationSyntax> structDeclarationSyntaxes = [];
            List<EnumDeclarationSyntax> enumDeclarationSyntaxes = [];

            if (gameClassInfo.RawClassInfo.IsEnum)
            {

            }
            else
            {

            }

        }



        public static IEnumerable<MemberDeclarationSyntax> EnumPropertyDeclarationSyntax(MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO[] fieldInfoDTOs)
        {
            var constfields = classInfoDTO.GetConstFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset);
            foreach (var f in CreateConstField(classInfoDTO, constfields))
            {
                yield return f;
            }

            var staticfields = classInfoDTO.GetStaticFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset);
            foreach (var f in CreateMemberField(classInfoDTO, staticfields, true))
            {
                yield return f;
            }

            var memberfields = classInfoDTO.GetMemberFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset);
            foreach (var f in CreateMemberField(classInfoDTO, memberfields, false))
            {
                yield return f;
            }

            static IEnumerable<MemberDeclarationSyntax> CreateConstField(MonoClassInfoDTO classInfoDTO, IOrderedEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    var typeName = SyntaxFactory.ParseTypeName(field.GetFieldTypeDisplayName()!);
                    var name = field.GetFixedFieldName(true)!;
                    var variableDeclaration = SyntaxFactory.VariableDeclaration(typeName,
                        [
                            SyntaxFactory.VariableDeclarator(name)
                            .WithInitializer(
                                SyntaxFactory.EqualsValueClause(
                                    SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression,SyntaxFactory.Literal(field.Value??string.Empty))
                                )
                            )
                        ]);


                    yield return SyntaxFactory.FieldDeclaration(variableDeclaration)
                        .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword)])
                        .WithLeadingTrivia(BuildSummaryComment([
                                GetFieldFullName(field.FieldType)
                        ]));



                }
            }

            static IEnumerable<PropertyDeclarationSyntax> CreateMemberField(MonoClassInfoDTO classInfoDTO, IOrderedEnumerable<MonoFieldInfoDTO> fieldInfoDTOs, bool isStatic)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    var typeName = SyntaxFactory.ParseTypeName(field.GetFieldTypeDisplayName()!);
                    var name = field.GetFixedFieldName()!;


                    yield return
                    SyntaxFactory.PropertyDeclaration(typeName, name)
                    .WithModifiers([
                        ..EnumModifiers(isStatic)
                    ])
                    .WithAccessorList(
                        SyntaxFactory.AccessorList([
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration )
                                .WithSemicolonToken(SyntaxFactory.Token( SyntaxKind.SemicolonToken)),
                            SyntaxFactory.AccessorDeclaration( SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token( SyntaxKind.SemicolonToken)),
                        ])
                    )
                    .WithLeadingTrivia(BuildSummaryComment([
                        GetFieldFullName(field.FieldType)
                    ]))
                    .WithAttributeLists([
                        SyntaxFactory.AttributeList([
                              NewClassPropertyMetadataAttribute(field)
                        ])
                    ]);

                }
                static IEnumerable<SyntaxToken> EnumModifiers(bool isStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                    yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                    if (isStatic)
                    {
                        yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                    }
                }
            }

        }

        public static IEnumerable<MethodDeclarationSyntax> EnumMethodDeclarationSyntax(MonoClassInfoDTO classInfoDTO, MonoMethodInfoDTO[] methodInfoDTOs)
        {
            foreach (var method in methodInfoDTOs)
            {
                var displayRetTypeName = SyntaxFactory.ParseTypeName(method.ReturnType.GetTypeDisplayName()!);
                var displayMethodName = method.Name.ToTitle();

                yield return SyntaxFactory.MethodDeclaration(displayRetTypeName, displayMethodName)
                        .WithModifiers([.. EnumModifiers(method)])
                        .WithParameterList(
                            SyntaxFactory.ParameterList([
                                ..EnumParameterListSyntax(method)
                            ])
                        )
                        .WithAttributeLists([
                            SyntaxFactory.AttributeList(
                            [
                                NewClassMethodMetadataAttribute(method),
                                ..NewClassMethodParameterMetadataAttribute(method)
                            ])
                        ])
                        .WithLeadingTrivia(GetMethodDescription(method))
                       .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            }
            static IEnumerable<SyntaxToken> EnumModifiers(MonoMethodInfoDTO methodInfoDTO)
            {
                yield return SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                yield return SyntaxFactory.Token(SyntaxKind.PartialKeyword);
                if (methodInfoDTO.IsStatic)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.StaticKeyword);
                }
                if (methodInfoDTO.IsAbstract)
                {
                    yield return SyntaxFactory.Token(SyntaxKind.AbstractKeyword);
                }
            }

            static IEnumerable<ParameterSyntax> EnumParameterListSyntax(MonoMethodInfoDTO methodInfoDTO)
            {
                foreach (var p in methodInfoDTO.ParameterTypes)
                {
                    var name = p.ParameterName!;
                    var type = p.GetTypeDisplayName()!;
                    yield return SyntaxFactory.Parameter(SyntaxFactory.Identifier(name))
                        .WithType(SyntaxFactory.ParseTypeName(type));
                }
            }


        }



        public static ClassDeclarationSyntax CreateClassDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO)
        {
            throw new NotImplementedException();

        }

        public static StructDeclarationSyntax CreateStructDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO, MonoFieldInfoDTO[] fieldInfoDTOs)
        {
            var member = EnumFieldDeclarationSyntax(monoClassInfoDTO.GetMemberFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset));
            return SyntaxFactory.StructDeclaration($"Ref_{monoClassInfoDTO.GetFixedClassName()}")
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithAttributeLists([
                    SyntaxFactory.AttributeList(
                        [NewAttribute<StructLayoutAttribute, LayoutKind>(nameof(LayoutKind.Explicit))]
                    )
                ])
                .WithMembers([.. member]);

            static IEnumerable<FieldDeclarationSyntax> EnumFieldDeclarationSyntax(IOrderedEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    var baseType = SyntaxFactory.ParseTypeName(field.GetFieldTypeDisplayName()!);
                    var name = field.GetFixedFieldName()!;
                    VariableDeclarationSyntax variableDeclaration =
                     SyntaxFactory.VariableDeclaration(baseType, [SyntaxFactory.VariableDeclarator(name)]);


                    yield return SyntaxFactory.FieldDeclaration(variableDeclaration)
                        .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                        .WithAttributeLists([
                            SyntaxFactory.AttributeList(
                                [NewAttribute<FieldOffsetAttribute, int>($"0x{field.Offset:X}")]
                            )
                        ]);


                }

            }
        }

        public static EnumDeclarationSyntax CreateEnumDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO, MonoFieldInfoDTO[] fieldInfoDTOs)
        {

            var member = EnumMember(monoClassInfoDTO.GetEnumFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset));
            var baseType = SyntaxFactory.ParseTypeName(MonoCollectorExtensions.GetEnumTypeName(fieldInfoDTOs)!);

            return SyntaxFactory.EnumDeclaration(SyntaxFactory.Identifier(monoClassInfoDTO.Name!))
                  .WithBaseList(SyntaxFactory.BaseList([SyntaxFactory.SimpleBaseType(baseType)]))
                  .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                  .WithMembers([.. member])
                  .WithLeadingTrivia(BuildSummaryComment(monoClassInfoDTO.GetClassFullName()));
            static IEnumerable<EnumMemberDeclarationSyntax> EnumMember(IOrderedEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    yield return SyntaxFactory.EnumMemberDeclaration(field.Name!)
                           .WithEqualsValue(
                               SyntaxFactory.EqualsValueClause(
                                   SyntaxFactory.IdentifierName(
                                       field.Value!
                                   )
                               )
                           );
                }
            }
        }

        #region Helper
        static string ToTitle(this string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            return JsonNamingPolicy.SnakeCaseUpper.ConvertName(name);
            // return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(field);
        }
        static string? GetFieldTypeDisplayName(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return fieldInfoDTO.FieldType.GetTypeDisplayName();
        }
        static string? GetTypeDisplayName(this MonoClassInfoDTO typeInfoDTO)
        {
            if (typeInfoDTO.IsValueType)
            {
                if (typeInfoDTO.TypeName == typeof(void).FullName)
                {
                    return "void";
                }
                return typeInfoDTO.TypeName;
            }
            return MonoCollecotrConvString.DisplayName_IntPtr;
        }

        static string? GetFixedFieldName(this MonoFieldInfoDTO fieldInfoDTO, bool title = false)
        {
            var field = GetFixedFieldNameImp(fieldInfoDTO);
            return title ? field.ToTitle() : field;
            static string? GetFixedFieldNameImp(MonoFieldInfoDTO fieldInfoDTO)
            {
                var fieldName = fieldInfoDTO.Name;
                if (string.IsNullOrEmpty(fieldName))
                {
                    return fieldName;
                }
                var index0 = fieldName.IndexOf('<');
                if (index0 == -1)
                {
                    return fieldName;
                }
                var index1 = fieldName.IndexOf(">k__BackingField");
                if (index1 == -1)
                {
                    return fieldName;
                }
                return fieldName.Substring(index0 + 1, index1 - 1);
            }
        }
        static string GetObjectTypeInfo(this MonoClassInfoDTO classInfoDTO)
        {
            if (classInfoDTO.IsEnum)
            {
                return "enum";
            }
            else if (classInfoDTO.IsValueType)
            {
                return "struct";
            }
            else if (classInfoDTO.IsInterface)
            {
                return "interface";
            }
            else
            {

                if (classInfoDTO.IsStatic)
                {
                    return "static class";
                }
                else if (classInfoDTO.IsAbstract)
                {
                    return "abstract class";
                }
                else
                {
                    return "class";
                }
            }

        }

        static string? GetFixedClassName(this MonoClassInfoDTO classInfoDTO)
        {
            var className = classInfoDTO.Name;
            if (string.IsNullOrEmpty(className))
            {
                return className;
            }
            var index = className.IndexOf('`');
            if (index != -1)
            {
                return $"{className[..index]}{nameof(System.Collections.Generic)}";
            }
            if (className.StartsWith('.') && className.Length > 1)
            {
                return $"{className[1..]}";
            }
            return className;
        }
        static string GetClassFullName(this MonoClassInfoDTO classInfoDTO)
            => @$"[""{classInfoDTO.ImageName}"".""{classInfoDTO.Namespace}"".""{classInfoDTO.Name}""]";

        static string GetFieldFullName(this MonoClassInfoDTO classInfoDTO)
            => @$"{classInfoDTO.GetObjectTypeInfo()} {classInfoDTO.GetClassFullName()}";

        static string GetMethodFullName(this MonoMethodInfoDTO methodInfoDTO)
        {
            var staticName = methodInfoDTO.IsStatic ? "static" : string.Empty;
            var abstractName = methodInfoDTO.IsAbstract ? "abstract" : string.Empty;
            return $@"{staticName} {abstractName} {methodInfoDTO.ReturnType.TypeName} {methodInfoDTO.Name}({string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.TypeName} {p.ParameterName}"))})";
        }

        public static SyntaxTriviaList GetMethodDescription(this MonoMethodInfoDTO methodInfoDTO)
        {
            return BuildSummaryComment(
                [
                    methodInfoDTO.GetMethodFullName()
                ],
                methodInfoDTO.ParameterTypes.ToDictionary(p => p.TypeName!, p => p.ParameterName!),
                $"{methodInfoDTO.ReturnType.GetObjectTypeInfo()} {methodInfoDTO.ReturnType.TypeName}");
        }


        static AttributeSyntax NewAttribute<T_Attribute, T_ARG>(string value) where T_Attribute : Attribute
        {
            return SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(T_Attribute).FullName!))
                .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                [
                    SyntaxFactory.AttributeArgument(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.ParseName(typeof(T_ARG).FullName!),
                            SyntaxFactory.IdentifierName(value)
                        )
                    )
                ]));
        }
        static AttributeSyntax NewClassPropertyMetadataAttribute(MonoFieldInfoDTO fieldInfoDTO)
        {
            return SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassPropertyMetadataAttribute).FullName!))
                .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                [
                    SyntaxFactory.AttributeArgument(
                        ArrayInitializerExpression(fieldInfoDTO.Utf8Name)
                    ),
                    SyntaxFactory.AttributeArgument(
                        ArrayInitializerExpression(fieldInfoDTO.FieldType.Utf8TypeName)
                    )
                ]));
        }
        static AttributeSyntax NewClassMethodMetadataAttribute(MonoMethodInfoDTO methodInfoDTO)
        {
            return SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassMethodMetadataAttribute).FullName!))
                .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                [
                    SyntaxFactory.AttributeArgument(
                        ArrayInitializerExpression(methodInfoDTO.Utf8Name)
                    ),
                    SyntaxFactory.AttributeArgument(
                        ArrayInitializerExpression(methodInfoDTO.ReturnType.Utf8TypeName)
                    )
                ]));
        }
        static IEnumerable<AttributeSyntax> NewClassMethodParameterMetadataAttribute(MonoMethodInfoDTO methodInfoDTO)
        {
            foreach (var data in methodInfoDTO.ParameterTypes.Index())
            {
                yield return SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassMethodParameterMetadataAttribute).FullName!))
                .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                [
                    SyntaxFactory.AttributeArgument(
                        ArrayInitializerExpression(data.Item.Utf8TypeName)
                    ),
                    SyntaxFactory.AttributeArgument(
                       SyntaxFactory.LiteralExpression( SyntaxKind.NumericLiteralExpression,SyntaxFactory.Literal(data.Index))
                    )
                ]));
            }

        }

        static SyntaxTriviaList BuildSummaryComment(params string?[] summaryTexts)
        {
            var summaryComment = SyntaxFactory.TriviaList(
            SyntaxFactory.Trivia(
                SyntaxFactory.DocumentationCommentTrivia(
                    SyntaxKind.MultiLineDocumentationCommentTrivia,
                    [
                        SyntaxFactory.XmlNewLine(""),
                        SyntaxFactory.XmlMultiLineElement(
                            SyntaxFactory.XmlName("summary"),
                            [
                                ..EnumXmlTextSyntax(summaryTexts)
                            ]),
                        SyntaxFactory.XmlText("\r\n"),
                    ]
            )));

            static IEnumerable<XmlTextSyntax> EnumXmlTextSyntax(params string?[] summaryTexts)
            {
                foreach (var summaryText in summaryTexts)
                {
                    yield return SyntaxFactory.XmlNewLine("\r\n");
                    yield return SyntaxFactory.XmlText(summaryText ?? string.Empty);
                }
                yield return SyntaxFactory.XmlNewLine("\r\n");

            }
            return summaryComment;
        }
        static SyntaxTriviaList BuildSummaryComment(string?[] summaryTexts, IReadOnlyDictionary<string, string>? keyValues = default, string? returns = default)
        {
            var summaryComment = SyntaxFactory.TriviaList(
            SyntaxFactory.Trivia(
                SyntaxFactory.DocumentationCommentTrivia(
                    SyntaxKind.MultiLineDocumentationCommentTrivia,
                    [
                        SyntaxFactory.XmlNewLine(""),
                        SyntaxFactory.XmlMultiLineElement(
                            SyntaxFactory.XmlName("summary"),
                            [
                               ..EnumXmlTextSyntax(summaryTexts)
                            ]),
                        SyntaxFactory.XmlText("\r\n"),
                        ..EnumXmlElement(keyValues,returns),


                    ]
            )));

            return summaryComment;
            static IEnumerable<XmlTextSyntax> EnumXmlTextSyntax(params string?[] summaryTexts)
            {
                foreach (var summaryText in summaryTexts)
                {
                    yield return SyntaxFactory.XmlNewLine("\r\n");
                    yield return SyntaxFactory.XmlText(summaryText ?? string.Empty);
                }
                yield return SyntaxFactory.XmlNewLine("\r\n");

            }
            static IEnumerable<XmlNodeSyntax> EnumXmlElement(IReadOnlyDictionary<string, string>? keyValues, string? returns = default)
            {
                if (keyValues is null)
                {
                    yield break;
                }
                foreach (var v in keyValues)
                {

                    yield return SyntaxFactory.XmlNewLine("");
                    var tag = SyntaxFactory.XmlName("param");
                    yield return SyntaxFactory.XmlElement(
                         SyntaxFactory.XmlElementStartTag(tag)
                         .WithAttributes([SyntaxFactory.XmlNameAttribute(v.Key)]),
                         SyntaxFactory.XmlElementEndTag(tag))
                         .WithContent(SyntaxFactory.SingletonList<XmlNodeSyntax>(
                             SyntaxFactory.XmlText(v.Value)));
                    yield return SyntaxFactory.XmlText("\r\n");

                }
                if (string.IsNullOrEmpty(returns) == false)
                {
                    yield return SyntaxFactory.XmlNewLine("");
                    var tag = SyntaxFactory.XmlName("returns");
                    yield return SyntaxFactory.XmlElement(
                         SyntaxFactory.XmlElementStartTag(tag),
                         SyntaxFactory.XmlElementEndTag(tag))
                         .WithContent(SyntaxFactory.SingletonList<XmlNodeSyntax>(
                             SyntaxFactory.XmlText(returns!)));
                    yield return SyntaxFactory.XmlText("\r\n");
                }
            }
        }



        static ExpressionSyntax ArrayInitializerExpression<T>(T[]? items) where T : struct
        {
            var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName!))
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
        static ExpressionSyntax ArrayInitializerExpression<T>(T[]?[]? arrItems) where T : struct
        {
            var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(typeof(T).FullName!))
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

        static string ArrayDisplay<T>(this IEnumerable<T> arr)
            where T : struct
        {
            return $@"[{string.Join(", ", arr)}]";
        }

        #endregion

    }
}
