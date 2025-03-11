using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class ClassParentMetadataAttribute<TParent, TPtr>() : Attribute
    {

    }
}
