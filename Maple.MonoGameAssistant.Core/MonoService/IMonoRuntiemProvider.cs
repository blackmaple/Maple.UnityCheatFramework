﻿using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Core
{


    public interface IMonoRuntiemProvider
    {
        ILogger Logger { get; }
        EnumMonoRuntimeType RuntimeType { get; }
        #region MonoDomains

        IEnumerable<PMonoDomain> EnumMonoDomains();
        PMonoDomain GetMonoRootDomain();
        PMonoThread MonoAttachThread(PMonoDomain pMonoDomain);
        void MonoDetachThread(PMonoThread pMonoThread);

        #endregion

        #region MonoAssemblies
        IEnumerable<PMonoAssembly> EnumMonoAssemblies(PMonoDomain pMonoDomain);

        #endregion

        #region MonoImages

        IEnumerable<PMonoImage> EnumMonoImages(IEnumerable<PMonoAssembly> pMonoAssemblies);
        string? GetMonoImageFileName(PMonoImage pMonoImage);
        PMonoUtf8Char GetMonoImageName(PMonoImage pMonoImage);

        #endregion

        #region MonoClasses
        IEnumerable<PMonoInterface> EnumMonoInterfaces(PMonoClass pMonoClass);
        IEnumerable<PMonoClass> EnumMonoClasses(PMonoImage pMonoImage);
        IEnumerable<PMonoClass> EnumMonoParentClasses(PMonoClass pMonoClass);

        bool IsGenericClass(PMonoClass pMonoClass);
        bool IsEnumClass(PMonoClass pMonoClass);
        bool IsValueTypeClass(PMonoClass pMonoClass);
        bool HasParentClass(PMonoClass pMonoClass);
        //bool IsSubClassOf(PMonoClass PMonoClass, PMonoClass pParentClass, bool checkInteface);
        int GetMonoClassInstanceSize(PMonoClass pMonoClass);
        //bool TryGetMonoImage(PMonoAssembly pMonoAssembly, string imageName, out PMonoImage pMonoImage);
        //bool TryGetMonoImage(string imageName, out PMonoImage pMonoImage);
        //bool TryGetMonoClass(PMonoImage pMonoImage, string nameSpace, string className, out PMonoClass pMonoClass);
        bool TryGetMonoClass(PMonoImage pMonoImage, ReadOnlySpan<byte> utf8Namespace, ReadOnlySpan<byte> utf8ClassName, out PMonoClass pMonoClass);
        bool TryGetMonoClass(PMonoImage pMonoImage, uint type_token, out PMonoClass pMonoClass);
        //bool TryGetFirstMonoMethodPointer(PMonoImage pMonoImage, string nameSpace, string className, string methodName, out MonoMethodPointer methodPointer, int paramCount = -1);
        uint GetMonoClassTypeToken(PMonoClass pMonoClass);
        //    PMonoClass GetMonoEnumClass();
        PMonoImage GetMonoClassImage(PMonoClass pMonoClass);
        uint GetMonoClassFlags(PMonoClass pMonoClass);
        PMonoUtf8Char GetMonoClassName(PMonoClass pMonoClass);
        PMonoUtf8Char GetMonoClassNamespace(PMonoClass pMonoClass);
        PMonoType GetMonoClassType(PMonoClass pMonoClass);
        PMonoClass GetMonoClass(PMonoObject pMonoObject);
        #endregion

        #region MonoMethods
        //bool TryGetMonoMethod(PMonoClass pMonoClass, string methodName, out PMonoMethod pMonoMethod, int paramCount = -1);
        IEnumerable<PMonoMethod> EnumMonoMethods(PMonoClass pMonoClass);
        //IEnumerable<PMonoMethod> EnumMonoMethods(PMonoClass pMonoClass, IEnumerable<PMonoClass> pParentClasses);
        uint GetMonoMethodFlags(PMonoMethod pMonoMethod);
        //PMonoMethodHeader GetMonoMethodHeader(PMonoMethod pMonoMethod);
        MonoMethodPointer GetMonoMethodAddress(PMonoMethod pMonoMethod);
        PMonoUtf8Char GetMonoMethodName(PMonoMethod pMonoMethod);
        MonoMethodDescInfo GetMonoMethodInfo(PMonoMethod pMonoMethod);

        #endregion 

        #region MonoField
        IEnumerable<PMonoField> EnumMonoFields(PMonoClass pMonoClass);
        PMonoType GetMonoFieldType(PMonoField pMonoField);
        //PMonoField GetMonoFieldParent(PMonoField pMonoField);
        int GetMonoFieldOffset(PMonoField pMonoField);
        uint GetMonoFieldFlags(PMonoField pMonoField);
        PMonoUtf8Char GetMonoFieldName(PMonoField pMonoField);

        #endregion 

        #region MonoField->Enum&Const&Static
        T_Value GetMonoEnumFieldValue<T_Value>(PMonoDomain pMonoDomain, PMonoField pMonoField) where T_Value : unmanaged;
        bool GetMonoEnumFieldValueAsBuffer(PMonoDomain pMonoDomain, PMonoField pMonoField, Span<byte> buffer);
        PMonoAddress GetMonoStaticFieldAddress(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int fieldOffset);
        public T_STRUCT GetMonoStaticFieldValue<T_STRUCT>(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField) where T_STRUCT : unmanaged;
        bool GetMonoStaticFieldValueAsBuffer(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField, Span<byte> buffer);
        string? GetMonoStaticFieldValueAsString(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField, int readSize = -1);
        #endregion

        #region MonoType
        PMonoClass GetMonoTypeClass(PMonoType pMonoType);
        PMonoUtf8Char GetMonoTypeName(PMonoType pMonoType);
        EnumMonoType GetMonoTypeEnum(PMonoType pMonoFieldType);

        #endregion

        #region Common
        PMonoObject CreateMonoClassOnly(PMonoDomain pMonoDomain, PMonoClass pMonoClass);

        T_Struct CreateMonoClass<T_Struct>(PMonoDomain pMonoDomain, PMonoClass pMonoClass, bool execDefCtor) where T_Struct : unmanaged;

        PMonoString GetMonoString(PMonoDomain pMonoDomain, string str);
        PMonoString GetMonoString(PMonoDomain pMonoDomain, in ReadOnlySpan<char> str);
        PMonoArray CreateMonoArray(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int count);


        PDelegatePointer GetInternalCall(string signature);


        REF_MONO_GC_HANDLE MonoGCHandle(PMonoObject pMonoObject, bool pinned);
        PMonoObject MonoGCHandleTarget(REF_MONO_GC_HANDLE gchandle);
        void MonoGCHandleFree(REF_MONO_GC_HANDLE gchandle);

        #endregion
    }
}
