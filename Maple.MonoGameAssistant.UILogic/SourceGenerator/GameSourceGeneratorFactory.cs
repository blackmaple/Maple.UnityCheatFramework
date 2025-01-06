using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Maple.MonoGameAssistant.UILogic
{
    public static class GameSourceGeneratorFactory
    {

        static NamespaceDeclarationSyntax BuildNamespaceExpression(string containingNamespace, params MemberDeclarationSyntax[] memberDeclarationSyntaxes)
        {
            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(containingNamespace))
                .WithMembers([.. memberDeclarationSyntaxes]);
        }

        public static string OutputCode(
            MonoClassInfoDTO classInfoDTO,
            MonoFieldInfoDTO[] fieldInfoDTOs,
            MonoMethodInfoDTO[] methodInfoDTOs,
            MonoClassInfoDTO[] parentClasses,
            MonoInterfaceInfoDTO[] interfaceInfoDTOs,
            string containingNamespace)
        {



            if (classInfoDTO.IsEnum)
            {
                var enumMember = CreateEnumDeclarationSyntax(classInfoDTO, fieldInfoDTOs);
                return BuildNamespaceExpression(containingNamespace, enumMember).NormalizeWhitespace().ToFullString();

            }
            else
            {
                List<MemberDeclarationSyntax> members = [];

                if (classInfoDTO.IsValueType)
                {
                    var refMember = CreateRefStructDeclarationSyntax(classInfoDTO, fieldInfoDTOs);
                    members.Add(refMember);
                }

                var propMember = EnumPropertyDeclarationSyntax(classInfoDTO, fieldInfoDTOs);
                var methodMember = EnumMethodDeclarationSyntax(classInfoDTO, methodInfoDTOs);
                var ptrMember = CreatePtrStructDeclarationSyntax(classInfoDTO, [.. propMember, .. methodMember]);
                members.Add(ptrMember);
                var classMember = CreateClassDeclarationSyntax(classInfoDTO, parentClasses, interfaceInfoDTOs, [.. members]);
                return BuildNamespaceExpression(containingNamespace, classMember).NormalizeWhitespace().ToFullString();

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
                                     SyntaxFactory.IdentifierName(field.Value??"")
                                )
                            )
                        ]);


                    yield return SyntaxFactory.FieldDeclaration(variableDeclaration)
                        .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword)])
                        .WithLeadingTrivia(GetFieldDescription(field));



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
                    .WithAttributeLists([
                        NewClassPropertyMetadataAttribute(field)
                    ])
                    .WithLeadingTrivia(GetFieldDescription(field));

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
                             NewClassMethodMetadataAttribute(method),
                             ..NewClassMethodParameterMetadataAttribute(method)
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



        public static ClassDeclarationSyntax CreateClassDeclarationSyntax(
            MonoClassInfoDTO monoClassInfoDTO,
            MonoClassInfoDTO[] parentClasses,
            MonoInterfaceInfoDTO[] interfaceInfoDTOs,
            MemberDeclarationSyntax[] members)
        {
            var name = monoClassInfoDTO.GetFixedClassName()!;

            return SyntaxFactory.ClassDeclaration(name)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithMembers([.. members])
                .WithAttributeLists([
                    NewClassParentMetadataAttribute(monoClassInfoDTO),
                    NewClassModelMetadataAttribute(monoClassInfoDTO),
                ])
                .WithLeadingTrivia(GetClassDescription(monoClassInfoDTO, parentClasses, interfaceInfoDTOs));


        }

        public static StructDeclarationSyntax CreateRefStructDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO, MonoFieldInfoDTO[] fieldInfoDTOs)
        {
            var members = EnumFieldDeclarationSyntax(monoClassInfoDTO.GetMemberFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset));
            return SyntaxFactory.StructDeclaration(monoClassInfoDTO.CreateRefStructName())
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithAttributeLists([
                   NewAttribute<StructLayoutAttribute, LayoutKind>(nameof(LayoutKind.Explicit))
                ])
                .WithMembers([.. members]);

            static IEnumerable<FieldDeclarationSyntax> EnumFieldDeclarationSyntax(IOrderedEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    var baseType = SyntaxFactory.ParseTypeName(field.GetFieldTypeDisplayName()!);
                    var name = field.GetFixedFieldName()!;
                    var variableDeclaration = SyntaxFactory.VariableDeclaration(baseType, [SyntaxFactory.VariableDeclarator(name)]);

                    yield return SyntaxFactory.FieldDeclaration(variableDeclaration)
                        .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                        .WithAttributeLists([
                            NewAttribute<FieldOffsetAttribute>($"0x{field.Offset:X}")
                        ]);


                }

            }
        }

        public static StructDeclarationSyntax CreatePtrStructDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO, MemberDeclarationSyntax[] members)
        {
            var ptrStructName = monoClassInfoDTO.CreatePtrStructName();// $"Ptr_{monoClassInfoDTO.GetFixedClassName()}";
            var baseType = SyntaxFactory.ParseTypeName(typeof(nint).FullName!);
            var ctorArg = "ptr";
            var fieldName = $"m_{nameof(Pointer)}";

            var fieldDeclaration = SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(baseType)
                .WithVariables([
                        SyntaxFactory.VariableDeclarator(fieldName)
                        .WithInitializer(SyntaxFactory.EqualsValueClause(
                              SyntaxFactory.IdentifierName(ctorArg)
                            ))
                    ]))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)])
                .WithAttributeLists([
                    NewAttribute<MarshalAsAttribute,UnmanagedType>(nameof(UnmanagedType.SysInt))
                ]);


            var nint2Ptr = SyntaxFactory.ConversionOperatorDeclaration(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword), SyntaxFactory.ParseTypeName(ptrStructName))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
                .WithOperatorKeyword(SyntaxFactory.Token(SyntaxKind.OperatorKeyword))
                .WithParameterList(
                    SyntaxFactory.ParameterList([
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(ctorArg))
                        .WithType(baseType)
                    ])
                )
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.ObjectCreationExpression(
                            SyntaxFactory.IdentifierName(ptrStructName)
                        ).WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName(ctorArg))
                                )
                            )
                         )
                    )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var ptr2nint = SyntaxFactory.ConversionOperatorDeclaration(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword), baseType)
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
                .WithOperatorKeyword(SyntaxFactory.Token(SyntaxKind.OperatorKeyword))
                .WithParameterList(
                    SyntaxFactory.ParameterList([
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(ctorArg))
                        .WithType( SyntaxFactory.ParseTypeName(ptrStructName))
                    ])
                )
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.MemberAccessExpression(
                           SyntaxKind.SimpleMemberAccessExpression,
                           SyntaxFactory.IdentifierName(ctorArg),
                           SyntaxFactory.IdentifierName(fieldName)
                        )
                    )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var notisnull = SyntaxFactory.ConversionOperatorDeclaration(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword), SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.BoolKeyword)))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
                .WithOperatorKeyword(SyntaxFactory.Token(SyntaxKind.OperatorKeyword))
                .WithParameterList(
                    SyntaxFactory.ParameterList([
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(ctorArg))
                        .WithType(SyntaxFactory.ParseTypeName(ptrStructName))
                    ])
                )
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.BinaryExpression(
                            SyntaxKind.NotEqualsExpression,
                            SyntaxFactory.MemberAccessExpression(
                               SyntaxKind.SimpleMemberAccessExpression,
                               SyntaxFactory.IdentifierName(ctorArg),
                               SyntaxFactory.IdentifierName(fieldName)
                            ),
                            SyntaxFactory.MemberAccessExpression(
                               SyntaxKind.SimpleMemberAccessExpression,
                               SyntaxFactory.IdentifierName(typeof(nint).FullName!),
                               SyntaxFactory.IdentifierName(nameof(IntPtr.Zero))
                            )
                        )

                    )
                )
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));





            var ptrProp = SyntaxFactory.PropertyDeclaration(baseType, nameof(IPtrMetadata.Ptr))
                .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.IdentifierName(fieldName)
                    ))
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword)])
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

            var ptrStruct = SyntaxFactory.StructDeclaration(ptrStructName)
                .WithModifiers([SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.UnsafeKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)])
                .WithAttributeLists([
                    NewAttribute<StructLayoutAttribute,LayoutKind>(nameof(LayoutKind.Sequential)),
                ])
                .WithParameterList(
                    SyntaxFactory.ParameterList([
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier(ctorArg)).WithType(baseType)
                    ])
                )
                .WithBaseList(SyntaxFactory.BaseList([SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(typeof(IPtrMetadata).FullName!))]))
                .WithMembers([fieldDeclaration, ptrProp, nint2Ptr, ptr2nint, notisnull, .. members]);


            return ptrStruct;



        }

        public static MemberDeclarationSyntax CreateEnumDeclarationSyntax(MonoClassInfoDTO monoClassInfoDTO, MonoFieldInfoDTO[] fieldInfoDTOs)
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
        static string BuildInheritViewContent(this IReadOnlyList<MonoClassInfoDTO> classInfoDTOs)
        {
            return string.Join(":", classInfoDTOs.Select(p => $"[{p.TypeName}]"));
        }
        static string CreatePtrStructName(this MonoClassInfoDTO classInfoDTO)
        {
            return $"Ptr_{classInfoDTO.GetFixedClassName()}";
        }
        static string CreateRefStructName(this MonoClassInfoDTO classInfoDTO)
        {
            return $"Ref_{classInfoDTO.GetFixedClassName()}";
        }

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
        static SyntaxTriviaList GetClassDescription(this MonoClassInfoDTO classInfoDTO,
            MonoClassInfoDTO[] parentClasses,
            MonoInterfaceInfoDTO[] interfaceInfoDTOs)
        {
            return BuildSummaryComment([
                 $"{classInfoDTO.GetObjectTypeInfo()} {classInfoDTO.GetClassFullName()}",
                 parentClasses.BuildInheritViewContent(),
                 interfaceInfoDTOs.BuildInheritViewContent(),
            ]);
        }


        static string GetFieldFullName(this MonoFieldTypeDTO fieldTypeDTO)
            => @$"{fieldTypeDTO.GetObjectTypeInfo()} {fieldTypeDTO.GetClassFullName()}";
        static SyntaxTriviaList GetFieldDescription(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return BuildSummaryComment([
                  $@"0x{fieldInfoDTO.RawOffset:X} {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name}",
                  fieldInfoDTO.FieldType.GetFieldFullName(),
                ]);
        }

        static string GetMethodFullName(this MonoMethodInfoDTO methodInfoDTO)
        {
            var staticName = methodInfoDTO.IsStatic ? "static" : string.Empty;
            var abstractName = methodInfoDTO.IsAbstract ? "abstract" : string.Empty;
            return $@"{staticName} {abstractName} {methodInfoDTO.ReturnType.TypeName} {methodInfoDTO.Name}({string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.TypeName} {p.ParameterName}"))})";
        }
        static SyntaxTriviaList GetMethodDescription(this MonoMethodInfoDTO methodInfoDTO)
        {
            return BuildSummaryComment(
                [
                    methodInfoDTO.GetMethodFullName()
                ],
                methodInfoDTO.ParameterTypes.Select(p => new KeyValuePair<string, string>(p.TypeName!, p.ParameterName!)),
                $"{methodInfoDTO.ReturnType.GetObjectTypeInfo()} {methodInfoDTO.ReturnType.TypeName}");
        }


        static AttributeListSyntax NewAttribute<T_Attribute, T_ARG>(string value) where T_Attribute : Attribute
        {
            return
                SyntaxFactory.AttributeList([
                    SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(T_Attribute).FullName!))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList([
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.ParseName(typeof(T_ARG).FullName!),
                                SyntaxFactory.IdentifierName(value)
                                )
                            )
                        ])
                    )
                ]);
        }
        static AttributeListSyntax NewAttribute<T_Attribute>(string value) where T_Attribute : Attribute
        {
            return
                SyntaxFactory.AttributeList([
                    SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(T_Attribute).FullName!))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList([
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.IdentifierName(value)
                            )
                        ])
                    )
                ]);
        }

        static AttributeListSyntax NewClassPropertyMetadataAttribute(MonoFieldInfoDTO fieldInfoDTO)
        {
            return
            SyntaxFactory.AttributeList([
                SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassPropertyMetadataAttribute).FullName!))
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList([
                        SyntaxFactory.AttributeArgument(
                            ArrayInitializerExpression(fieldInfoDTO.Utf8Name)
                        ),
                        SyntaxFactory.AttributeArgument(
                            ArrayInitializerExpression(fieldInfoDTO.FieldType.Utf8TypeName)
                        )
                    ])
                )
            ]);
        }
        static AttributeListSyntax NewClassMethodMetadataAttribute(MonoMethodInfoDTO methodInfoDTO)
        {
            return
                SyntaxFactory.AttributeList([
                    SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassMethodMetadataAttribute).FullName!))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList([
                            SyntaxFactory.AttributeArgument(
                                ArrayInitializerExpression(methodInfoDTO.Utf8Name)
                            ),
                            SyntaxFactory.AttributeArgument(
                                ArrayInitializerExpression(methodInfoDTO.ReturnType.Utf8TypeName)
                            )
                        ])
                    )
                ]);
        }
        static IEnumerable<AttributeListSyntax> NewClassMethodParameterMetadataAttribute(MonoMethodInfoDTO methodInfoDTO)
        {
            foreach (var data in methodInfoDTO.ParameterTypes.Index())
            {
                yield return
                SyntaxFactory.AttributeList([
                    SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(ClassMethodParameterMetadataAttribute).FullName!))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList([
                            SyntaxFactory.AttributeArgument(
                                ArrayInitializerExpression(data.Item.Utf8TypeName)
                            ),
                            SyntaxFactory.AttributeArgument(
                               SyntaxFactory.LiteralExpression( SyntaxKind.NumericLiteralExpression,SyntaxFactory.Literal(data.Index))
                            )
                        ])
                    )
                ]);
            }

        }


        //static AttributeSyntax NewContextMemberMetadataAttribute()
        //{
        //    return
        //    SyntaxFactory.Attribute(
        //        SyntaxFactory.IdentifierName(typeof(ClassPropertyMetadataAttribute).FullName!)
        //    )
        //    .WithArgumentList(SyntaxFactory.AttributeArgumentList(
        //    [
        //        SyntaxFactory.AttributeArgument(ArrayInitializerExpression() ),

        //    ]));
        //}

        static AttributeListSyntax NewClassParentMetadataAttribute(MonoClassInfoDTO classInfoDTO)
        {
            var ptrType = SyntaxFactory.ParseTypeName(classInfoDTO.CreatePtrStructName());
            return
            SyntaxFactory.AttributeList([
                SyntaxFactory.Attribute(
                    SyntaxFactory.GenericName(typeof(ClassParentMetadataAttribute<,>).FullName!.Replace("`2",""))
                    .WithTypeArgumentList(
                        SyntaxFactory.TypeArgumentList([
                            SyntaxFactory.GenericName(typeof(ClassMetadataCollector<>).FullName!.Replace("`1","")).WithTypeArgumentList(SyntaxFactory.TypeArgumentList([ptrType])),
                            ptrType
                        ])
                    )
                )
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList([
                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.TrueLiteralExpression, SyntaxFactory.Token( SyntaxKind.TrueKeyword))),
                    ])
                )
            ]);
        }
        static AttributeListSyntax NewClassModelMetadataAttribute(MonoClassInfoDTO classInfoDTO)
        {
            return
                SyntaxFactory.AttributeList([
                    SyntaxFactory.Attribute(
                        SyntaxFactory.IdentifierName(typeof(ClassModelMetadataAttribute).FullName!)
                    )
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList([
                            SyntaxFactory.AttributeArgument(ArrayInitializerExpression(classInfoDTO.Utf8ImageName)),
                            SyntaxFactory.AttributeArgument(ArrayInitializerExpression(classInfoDTO.Utf8Namespace)),
                            SyntaxFactory.AttributeArgument(ArrayInitializerExpression(classInfoDTO.Utf8Name)),
                            SyntaxFactory.AttributeArgument(ArrayInitializerExpression(classInfoDTO.Utf8FullName)),
                        ])
                    )
                ]);

        }

        static SyntaxTriviaList BuildSummaryComment(params string?[] summaryTexts)
        {
            var summaryContent = string.Join("\r\n", summaryTexts.Select(p => @$"/// {p}"));
            return SyntaxFactory.ParseLeadingTrivia(@$"

/// <summary>
{summaryContent}
/// </summary>
");
            //var summaryComment = SyntaxFactory.TriviaList(
            //SyntaxFactory.Trivia(
            //    SyntaxFactory.DocumentationCommentTrivia(
            //        SyntaxKind.MultiLineDocumentationCommentTrivia,
            //        [
            //            SyntaxFactory.XmlNewLine(""),
            //            SyntaxFactory.XmlMultiLineElement(
            //                SyntaxFactory.XmlName("summary"),
            //                [
            //                    ..EnumXmlTextSyntax(summaryTexts)
            //                ]),
            //            SyntaxFactory.XmlText("\r\n"),
            //        ]
            //)));

            //static IEnumerable<XmlTextSyntax> EnumXmlTextSyntax(params string?[] summaryTexts)
            //{
            //    foreach (var summaryText in summaryTexts)
            //    {
            //        yield return SyntaxFactory.XmlNewLine("\r\n");
            //        yield return SyntaxFactory.XmlText(summaryText ?? string.Empty);
            //    }
            //    yield return SyntaxFactory.XmlNewLine("\r\n");

            //}
            //return summaryComment;
        }
        static SyntaxTriviaList BuildSummaryComment(string?[] summaryTexts, IEnumerable<KeyValuePair<string, string>>? keyValues, string? returns = default)
        {
            var returnsContent = @$"/// <returns>{returns}</returns>";
            var summaryContent = string.Join("\r\n", summaryTexts.Select(p => @$"/// {p}"));

            if (keyValues is null || keyValues.Any() == false)
            {
                return SyntaxFactory.ParseLeadingTrivia(@$"
/// <summary>
{summaryContent}
/// </summary>
{returnsContent}
");
            }
            var paramContent = string.Join("\r\n", keyValues.Select(p => $@"/// <param name=""{p.Key}"">{p.Value}</param>"));
            return SyntaxFactory.ParseLeadingTrivia(@$"
/// <summary>
{summaryContent}
/// </summary>
{paramContent}
{returnsContent}
");
            //return SyntaxFactory.TriviaList();
            //var summaryComment = SyntaxFactory.TriviaList(
            //SyntaxFactory.Trivia(
            //    SyntaxFactory.DocumentationCommentTrivia(
            //        SyntaxKind.MultiLineDocumentationCommentTrivia,
            //        [
            //            SyntaxFactory.XmlNewLine(""),
            //            SyntaxFactory.XmlMultiLineElement(
            //                SyntaxFactory.XmlName("summary"),
            //                [
            //                   ..EnumXmlTextSyntax(summaryTexts)
            //                ]),
            //            SyntaxFactory.XmlText("\r\n"),
            //            ..EnumXmlElement(keyValues,returns),


            //        ]
            //)));

            //return summaryComment;
            //static IEnumerable<XmlTextSyntax> EnumXmlTextSyntax(params string?[] summaryTexts)
            //{
            //    foreach (var summaryText in summaryTexts)
            //    {
            //        yield return SyntaxFactory.XmlNewLine("\r\n");
            //        yield return SyntaxFactory.XmlText(summaryText ?? string.Empty);
            //    }
            //    yield return SyntaxFactory.XmlNewLine("\r\n");

            //}
            //static IEnumerable<XmlNodeSyntax> EnumXmlElement(IEnumerable<KeyValuePair<string, string>>? keyValues, string? returns = default)
            //{
            //    if (keyValues is null)
            //    {
            //        yield break;
            //    }
            //    foreach (var v in keyValues)
            //    {

            //        yield return SyntaxFactory.XmlNewLine("");
            //        var tag = SyntaxFactory.XmlName("param");
            //        yield return SyntaxFactory.XmlElement(
            //             SyntaxFactory.XmlElementStartTag(tag)
            //             .WithAttributes([SyntaxFactory.XmlNameAttribute(v.Key)]),
            //             SyntaxFactory.XmlElementEndTag(tag))
            //             .WithContent(SyntaxFactory.SingletonList<XmlNodeSyntax>(
            //                 SyntaxFactory.XmlText(v.Value)));
            //        yield return SyntaxFactory.XmlText("\r\n");

            //    }
            //    if (string.IsNullOrEmpty(returns) == false)
            //    {
            //        yield return SyntaxFactory.XmlNewLine("");
            //        var tag = SyntaxFactory.XmlName("returns");
            //        yield return SyntaxFactory.XmlElement(
            //             SyntaxFactory.XmlElementStartTag(tag),
            //             SyntaxFactory.XmlElementEndTag(tag))
            //             .WithContent(SyntaxFactory.SingletonList<XmlNodeSyntax>(
            //                 SyntaxFactory.XmlText(returns!)));
            //        yield return SyntaxFactory.XmlText("\r\n");
            //    }
            //}
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
