using Microsoft.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ContextParentMetadataData
    {
        public ISymbol ParentSymbol { set; get; }
        public ISymbol ContextSymbol { set; get; }
    }
}
