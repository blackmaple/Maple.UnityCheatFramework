using System;
using System.Diagnostics;
#pragma warning disable CS9113 // 参数未读。

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
         class ContextParentMetadataAttribute<T>(bool build = false) : Attribute
    {

    }

}
#pragma warning restore CS9113 // 参数未读。
