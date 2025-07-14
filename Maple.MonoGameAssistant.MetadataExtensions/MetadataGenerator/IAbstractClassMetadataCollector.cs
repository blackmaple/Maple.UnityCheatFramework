namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
        interface IAbstractClassMetadataCollector
    {

      //  MonoMethodDelegate GetMethodDelegate(MonoJsonMethodDTO descriptionMethodDTO);

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
        ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, in MonoMemberFieldSource  fieldSource) where T_FieldValue : unmanaged;

#if !MetadataSourceGenerator
        static abstract
#endif
        void SetMemberFieldValue<T_FieldValue>(nint @this, in MonoMemberFieldSource fieldSource, in T_FieldValue value) where T_FieldValue : unmanaged;



    }
}
