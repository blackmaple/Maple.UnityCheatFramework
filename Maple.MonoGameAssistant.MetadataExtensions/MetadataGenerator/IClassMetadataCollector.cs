namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

#if MetadataSourceGenerator
    internal
#else
    public
#endif 
         interface IClassMetadataCollector : IAbstractClassMetadataCollector
    {
        MonoMethodDelegate GetMethodDelegate(ulong code);
        MonoMethodDelegate<TFUNC> GetMethodDelegate<TFUNC>(ulong code) where TFUNC : unmanaged;
        nint GetMethodPointer(ulong code);

        MonoMemberFieldSource GetMemberFieldMetadata(ulong code);
        MonoStaticFieldSource GetStaticFieldMetadata(ulong code);

        int GetMemberFieldOffset(ulong code);


        //#if !MetadataSourceGenerator
        //        static abstract
        //#endif
        //        T_FieldValue GetStaticFieldValue<T_FieldValue>(MonoStaticFieldSource staticFieldSource) where T_FieldValue : unmanaged;

        //#if !MetadataSourceGenerator
        //        static abstract
        //#endif
        //        void SetStaticFieldValue<T_FieldValue>(MonoStaticFieldSource staticFieldSource, in T_FieldValue value) where T_FieldValue : unmanaged;

        //#if !MetadataSourceGenerator
        //        static abstract
        //#endif
        //        ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset) where T_FieldValue : unmanaged;

        //#if !MetadataSourceGenerator
        //        static abstract
        //#endif
        //        void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value) where T_FieldValue : unmanaged;

        //        // static nint GetStaticFieldValueAsPointer(MonoStaticFieldSource staticFieldSource) { }
    }
}
