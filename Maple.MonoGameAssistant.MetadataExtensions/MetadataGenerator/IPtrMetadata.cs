using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         interface IPtrMetadata
    {
        nint Ptr { get; }
    }


}
