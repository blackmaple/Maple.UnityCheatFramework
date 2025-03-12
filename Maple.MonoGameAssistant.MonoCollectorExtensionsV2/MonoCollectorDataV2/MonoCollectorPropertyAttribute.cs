using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// 属性生成器
    /// </summary>
    [Conditional("DEBUG")]
    [Description("内部使用...")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal class MonoCollectorPropertyAttribute : Attribute
    {
        public string EntryPoint { set; get; }

        public string PropertyName { set; get; }

        public bool Search { set; get; } = true;



    }
#else 
    public class MonoCollectorPropertyAttribute : Attribute
    {
        public string? EntryPoint { set; get; }

        public string? PropertyName { set; get; }

        public bool Search { set; get; } = true;



    }
#endif    



}
