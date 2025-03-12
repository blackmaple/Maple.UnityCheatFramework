using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// Class标记
    /// </summary>
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]

#if SOURCE_GEN
    internal class MonoCollectorSettingsAttribute : Attribute
    {
        public byte[] Const_ImageName { set; get; }
        public byte[] Const_Namespace { set; get; }
        public byte[] Const_ClassName { set; get; }

        [Obsolete("remove...", true)]
        public uint Const_TypeToken { set; get; }

        [Obsolete("游戏更新导致token变动;不推荐使用", true)]
        public MonoCollectorSettingsAttribute(byte[] const_imageName, uint const_TypeToken)
        {

            Const_ImageName = const_imageName;
            Const_TypeToken = const_TypeToken;
        }

        public MonoCollectorSettingsAttribute(byte[] const_imageName, byte[] const_nameSpace, byte[] const_className)
        {

            Const_ImageName = const_imageName;
            Const_Namespace = const_nameSpace;
            Const_ClassName = const_className;
        }
    }
#else
    public class MonoCollectorSettingsAttribute : Attribute
    {
        public byte[]? Const_ImageName { set; get; }
        public byte[]? Const_Namespace { set; get; }
        public byte[]? Const_ClassName { set; get; }

        [Obsolete("remove...", true)]
        public uint Const_TypeToken { set; get; }

        [Obsolete("游戏更新导致token变动;不推荐使用", true)]
        public MonoCollectorSettingsAttribute(byte[] const_imageName, uint const_TypeToken)
        {

            Const_ImageName = const_imageName;
            Const_TypeToken = const_TypeToken;
        }

        public MonoCollectorSettingsAttribute(byte[] const_imageName, byte[] const_nameSpace, byte[] const_className)
        {

            Const_ImageName = const_imageName;
            Const_Namespace = const_nameSpace;
            Const_ClassName = const_className;
        }
    }
#endif


}
