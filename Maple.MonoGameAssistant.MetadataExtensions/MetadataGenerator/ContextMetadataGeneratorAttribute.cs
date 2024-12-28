using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class ContextMetadataCtorAttribute(Type type) : Attribute
    {
        public Type Type { get; } = type;
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class ContextMetadataCtorAttribute<T>() : ContextMetadataCtorAttribute(typeof(T))
    {

    }

}
