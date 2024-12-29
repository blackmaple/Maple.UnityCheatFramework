﻿using System;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         class ContextCtorMetadataAttribute<T>() : Attribute
    {

    }

}
