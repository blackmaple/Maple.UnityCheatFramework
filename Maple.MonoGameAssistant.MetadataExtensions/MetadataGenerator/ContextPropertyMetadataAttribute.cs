using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class ContextPropertyMetadataAttribute<T>() : Attribute()
    {

    }
}
