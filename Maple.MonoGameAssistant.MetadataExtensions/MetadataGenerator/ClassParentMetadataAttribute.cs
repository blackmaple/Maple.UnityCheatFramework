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

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
 class GenericClassParentMetadataAttribute(Type parent, Type ptr) : Attribute
    {
        public Type TParent { get; } = parent;
        public Type TPtr { get; } = ptr;
    }
}
