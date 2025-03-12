using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]

#if SOURCE_GEN
    internal
#else 
    public
#endif

        class MonoCollectorTypeAttribute : Attribute
    {
        public Type ClassType { set; get; }

        public EnumMonoCollectorTypeVersion Ver { set; get; } = EnumMonoCollectorTypeVersion.APP;

        public MonoCollectorTypeAttribute(Type classType)
        {
            ClassType = classType;
        }


    }


}
