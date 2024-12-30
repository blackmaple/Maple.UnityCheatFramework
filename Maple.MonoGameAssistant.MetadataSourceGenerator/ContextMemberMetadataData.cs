using Microsoft.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ContextMemberMetadataData
    {
        public ISymbol ParentSymbol { set; get; }
        public ISymbol ContextSymbol { set; get; }

        public ISymbol[] ClassSymbols { set; get; }
    }
}
