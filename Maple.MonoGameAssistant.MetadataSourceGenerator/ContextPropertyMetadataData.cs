using Microsoft.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ContextPropertyMetadataData
    {
        public ISymbol ContextSymbol { set; get; }
        public ISymbol[] ClassSymbols { set; get; }
    }
}
