using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{


    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        class ContextMemberMetadataAttribute<T>() : Attribute()
    {

    }
}
