using Microsoft.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ClassMetadataData
    {
        public ISymbol ClassSymbol { set; get; }
        public ISymbol[] FieldSymbols { set; get; }
        public ISymbol[] MethodSymbols { set; get; }

    }
}
