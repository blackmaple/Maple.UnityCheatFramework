using Microsoft.CodeAnalysis;
using System.Reflection;
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassMemberMetadataData
    {
        public ulong Code { set; get; }

        public ISymbol ParentSymbol { set; get; } = default!;

        public byte[]? Utf8ImageName { set; get; }
        public byte[]? Utf8Namespace { set; get; }
        public byte[]? Utf8ClassName { set; get; }
        public byte[]? Utf8FullName { set; get; }

        public ISymbol ContextSymbol { set; get; } = default!;
        public ISymbol PtrSymbol { set; get; } = default!;

        public ClassPropertyMetadataData[] PropertyMetadataDatas { set; get; } = default!;
        public ClassMethodMetadataData[] MethodMetadataDatas { set; get; } = default!;



        public MonoJsonClassDTO GetJsonClass()
        {
            return new MonoJsonClassDTO()
            {
                Code = this.Code,
                Utf8ImageName = Utf8ImageName,
                Utf8Namespace = Utf8Namespace,
                Utf8ClassName = Utf8ClassName,
                Utf8Name = Utf8FullName,
            };
        }

        public IEnumerable<MonoJsonMethodDTO> EnumJsonMethod()
        {
            foreach (var method in this.MethodMetadataDatas)
            {
                yield return new MonoJsonMethodDTO()
                {
                    Code = method.Code,
                    Utf8Name = method.Utf8MethodName,
                    Utf8ReturnType = method.Utf8MethodReturnType,
                    Utf8Parameters = method.Utf8MethodParameterTypes,
                };
            }
        }

        public IEnumerable<MonoJsonFieldDTO> EnumJsonField()
        {
            foreach (var method in this.PropertyMetadataDatas)
            {
                yield return new MonoJsonFieldDTO()
                {
                    Code = method.Code,
                    Utf8Name = method.Utf8PropertyName,
                    Utf8FieldType = method.Utf8PropertyName,
                    IsStatic = method.PropertySymbol.IsStatic,
                };
            }
        }

    }

}
#pragma warning restore CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
