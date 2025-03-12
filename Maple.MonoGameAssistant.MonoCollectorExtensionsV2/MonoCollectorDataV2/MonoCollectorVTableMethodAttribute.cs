using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// 标记[extern] 
    /// 仅支持virtual
    /// </summary>
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal class MonoCollectorVTableMethodAttribute : Attribute
    {
        public int MethodOffset { get; }

        //[Obsolete("remove...")]
        //public int VTableOffset { get; set; }
        public string VTableField { get; set; }
        public Type[] CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;
        public MonoCollectorVTableMethodAttribute(int methodOffset)
        {
            MethodOffset = methodOffset;
        }
    }
#else 
    public class MonoCollectorVTableMethodAttribute : Attribute
    {
        public int MethodOffset { get; }

        //[Obsolete("remove...")]
        //public int VTableOffset { get; set; }
        public string? VTableField { get; set; }
        public Type[]? CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;
        public MonoCollectorVTableMethodAttribute(int methodOffset)
        {
            MethodOffset = methodOffset;
        }
    }
#endif   

}
