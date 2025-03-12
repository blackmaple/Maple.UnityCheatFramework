using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal
#else 
    public
#endif 
        class MonoCollectorFlagAttribute : Attribute
    {
        public MonoCollectorFlagAttribute(EnumMonoCollectorFlag flag)
        {
            Flag = flag;
        }

        public EnumMonoCollectorFlag Flag { get; }

    }

#if SOURCE_GEN
    internal
#else 
    public
#endif
        enum EnumMonoCollectorFlag
    {
        None,
        ContextCtor,
        GetClassInfo,
        Throw,

        MemberCtor,
        InitMember,
        GetMethodPointer,
        GetStaticMethodInvoker,
        GetMonoStaticFieldValue,
        TryGetModuleBaseAddress,
        GetModuleBaseAddress,
        New,
        Ctor,
        NewArray,
        GetMemberFieldOffset,
        GetMemberFieldValue,
        SetMemberFieldValue
    }
}
