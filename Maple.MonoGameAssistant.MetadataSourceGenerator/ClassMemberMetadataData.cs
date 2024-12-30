using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassMemberMetadataData
    {
        public ISymbol ParentSymbol { set; get; }
        public ISymbol MetadataSymbol { set; get; }

        public ISymbol ContextSymbol { set; get; }

        public ISymbol PtrSymbol { set; get; }

        public ISymbol[] FieldSymbols { set; get; }
        public ISymbol[] MethodSymbols { set; get; }

    }

    public class ClassPropertyMetadataData
    {
        public ISymbol PropertySymbol { set; get; }
        public byte[] PropertyName { set; get; }
        public byte[] PropertyType { set; get; }
    }


    public class ClassMethodMetadataData
    {
        public ISymbol MethodSymbol { set; get; }
        public byte[] MethodName { set; get; }
        public byte[] MethodReturnType { set; get; }
        public List<byte[]> MethodParameterTypes { set; get; }
    }

}
