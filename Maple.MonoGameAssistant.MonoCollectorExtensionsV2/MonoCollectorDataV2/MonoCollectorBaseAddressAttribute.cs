using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// 标记[extern] 
    /// 仅支持unsafe
    /// 通过基址+偏移获取方法地址或属性值
    /// </summary>
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal class MonoCollectorBaseAddressAttribute : MonoCollectorCallConvsAttribute
    {
        public string Module { get; }
        public int BaseOffset { get; }
        public int[] Offsets { get; set; }
        /// <summary>
        /// 对于方法可以false提前获取地址
        /// 对于属性可以true每次调用获取值
        /// </summary>
        public bool RealTime { set; get; } = false;

        public MonoCollectorBaseAddressAttribute(string name, int baseOffset)
        {
            Module = name;
            BaseOffset = baseOffset;

        }



    }
#else
    public class MonoCollectorBaseAddressAttribute : MonoCollectorCallConvsAttribute
    {
        public string? Module { get; }
        public int BaseOffset { get; }
        public int[]? Offsets { get; set; }
        /// <summary>
        /// 对于方法可以false提前获取地址
        /// 对于属性可以true每次调用获取值
        /// </summary>
        public bool RealTime { set; get; } = false;

        public MonoCollectorBaseAddressAttribute(string name, int baseOffset)
        {
            Module = name;
            BaseOffset = baseOffset;

        }



    }
#endif


    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.All)]
#if SOURCE_GEN
    internal class MonoCollectorCallConvsAttribute : Attribute
    {
        public Type[] CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;

    }
#else 
    public class MonoCollectorCallConvsAttribute : Attribute
    {
        public Type[]? CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;

    }
#endif  

}
