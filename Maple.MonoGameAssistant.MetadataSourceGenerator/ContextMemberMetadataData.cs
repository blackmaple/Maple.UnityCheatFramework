using Microsoft.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public class ContextMemberMetadataData
    {
        public ISymbol ParentSymbol { set; get; } = default!;
        public ISymbol ContextSymbol { set; get; } = default!;

        public ISymbol[] ClassSymbols { set; get; } = default!;

        public bool ExportJson { set; get; }


    }
}
