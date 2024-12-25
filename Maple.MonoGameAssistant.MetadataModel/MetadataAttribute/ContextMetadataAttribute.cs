using System;

namespace Maple.MonoGameAssistant.MetadataModel.MetadataAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ContextMetadataAttribute(Type classMetadata) : Attribute
    {
        public Type ClassMetadata { get; } = classMetadata;
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ContextMetadataAttribute<T>(): ContextMetadataAttribute(typeof(T))
    { 
    
    }
}
