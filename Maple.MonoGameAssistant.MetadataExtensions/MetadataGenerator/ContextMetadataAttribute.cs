using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class ContextMetadataAttribute(Type classMetadata) : Attribute
    {
        public Type ClassMetadata { get; } = classMetadata;
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class ContextMetadataAttribute<T>() : ContextMetadataAttribute(typeof(T))
    {

    }
}
