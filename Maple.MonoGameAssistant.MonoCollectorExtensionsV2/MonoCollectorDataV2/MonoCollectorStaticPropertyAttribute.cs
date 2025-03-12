using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// 静态属性生成器
    /// </summary>
    [Description("内部使用...")]
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]

#if SOURCE_GEN
    internal class MonoCollectorStaticPropertyAttribute : Attribute
    {
        public string EntryPoint { get; set; }
        public string PropertyName { get; set; }
    }
#else 
    public class MonoCollectorStaticPropertyAttribute : Attribute
    {
        public string? EntryPoint { get; set; }
        public string? PropertyName { get; set; }
    }
#endif

}
