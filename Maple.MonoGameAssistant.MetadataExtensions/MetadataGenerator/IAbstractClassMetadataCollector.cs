namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        interface IAbstractClassMetadataCollector
    {

#if !MetadataSourceGenerator
        static abstract
#endif
        T_FieldValue GetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource) where T_FieldValue : unmanaged;

#if !MetadataSourceGenerator
        static abstract
#endif
        void SetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource, in T_FieldValue value) where T_FieldValue : unmanaged;

#if !MetadataSourceGenerator
        static abstract
#endif
        ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset) where T_FieldValue : unmanaged;

#if !MetadataSourceGenerator
        static abstract
#endif
        void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value) where T_FieldValue : unmanaged;



    }
}
