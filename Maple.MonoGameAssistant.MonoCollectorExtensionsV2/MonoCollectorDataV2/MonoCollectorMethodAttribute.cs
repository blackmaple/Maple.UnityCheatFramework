using System;
using System.Diagnostics;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
    /// <summary>
    /// 标记[extern] 
    /// 支持static
    /// virtual的方法请使用MonoCollectorVTableAttribute 查询虚表找函数
    /// </summary>
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal class MonoCollectorMethodAttribute : Attribute
    {
        public string EntryPoint { get; }

        public Type Search { set; get; }

        public Type[] CallConvs { set; get; }

        public bool SuppressGCTransition { set; get; } = true;

        public bool FromRuntimeMethod { get; set; } = false;
        public MonoCollectorMethodAttribute(string entryPoint)
        {
            EntryPoint = entryPoint;
        }
    }
#else
    public class MonoCollectorMethodAttribute : Attribute
    {
        public string? EntryPoint { get; }

        public Type? Search { set; get; }

        public Type[]? CallConvs { set; get; }

        public bool SuppressGCTransition { set; get; } = true;

        public bool FromRuntimeMethod { get; set; } = false;
        public MonoCollectorMethodAttribute(string entryPoint)
        {
            EntryPoint = entryPoint;
        }
    }
#endif



}
