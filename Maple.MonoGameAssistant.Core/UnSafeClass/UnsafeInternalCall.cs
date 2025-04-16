using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{
    /// <summary>
    /// https://github.com/LavaGang/MelonLoader/blob/master/Dependencies/MelonStartScreen/UnhollowerMini/UnityInternals.cs
    /// </summary>
    internal unsafe class UnsafeInternalCall
    {

        static UnsafeInternalCall? s_Instance;

        MonoRuntimeApi Runtime { get; }

        int MonoClassOffset { get; }

        public UnsafeInternalCall(MonoRuntimeApi rt)
        {
            this.Runtime = rt;
            this.MonoClassOffset = GetMonoClassOffset();
        }

        public static PDelegatePointer GetInternalCall(MonoRuntimeApi rt, string signature)
        {
            var methodInfo = ParsedMethod.ParseMethodString(signature);
            s_Instance ??= new UnsafeInternalCall(rt);
            return s_Instance.GetInternalCall_FakeImp(methodInfo);
        }

        PDelegatePointer GetInternalCall_FakeImp(ParsedMethod methodInfo)
        {
            var monoClass = new RefMonoClass();
            var monoMethod = new RefMonoMethod
            {
                klass = PMonoObject<RefMonoClass>.AsPointer(ref monoClass)
            };


            using var ref_methodName = methodInfo.MethodName.AsUnmanaged(Encoding.UTF8, []);
            using var ref_namespace = methodInfo.Namespace.AsUnmanaged(Encoding.UTF8, []);
            using var ref_className = methodInfo.ClassName.AsUnmanaged(Encoding.UTF8, []);
            fixed (void* pMethodName = &ref_methodName.GetPinnableReference())
            fixed (void* pNamespace = &ref_namespace.GetPinnableReference())
            fixed (void* pclassName = &ref_className.GetPinnableReference())
            {
                monoMethod.name = pMethodName;

                ref var ref_class_namespace = ref monoClass.GetNamespace(MonoClassOffset);
                ref_class_namespace = pNamespace;

                ref var ref_class_name = ref monoClass.GetClassName(MonoClassOffset);
                ref_class_name = pclassName;

                var monoMethodSignature = new RefMonoMethodSignature();
                monoMethod.signature = PMonoObject<RefMonoMethodSignature>.AsPointer(ref monoMethodSignature);

                nint pMonoMethod = PMonoObject<RefMonoMethod>.AsPointer(ref monoMethod);
                return this.Runtime.MONO_LOOKUP_INTERNAL_CALL.Invoke(pMonoMethod);
            }
        }


        unsafe int GetMonoClassOffset()
        {
            const nint Flag_1 = 0xAAAA;
            const nint Flag_2 = 0xBBBB;
            const nint Flag_3 = 0xCCCC;

            var monoClass = new RefMonoClass
            {
                nested_in_0x04 = Flag_1,
                nested_in_0x08 = Flag_2,
                nested_in_0x0C = Flag_3,
            };
            nint pointer = PMonoObject<RefMonoClass>.AsPointer(ref monoClass);
            var className = this.Runtime.MONO_CLASS_GET_NAME.Invoke(pointer);

            if (className == Flag_1)
            {
                return nint.Size * 0;
            }
            else if (className == Flag_2)
            {
                return nint.Size * 1;
            }
            else if (className == Flag_3)
            {
                return nint.Size * 2;
            }
            return MonoRuntimeException.Throw<int>("Failed to find MonoClass name offset");
        }


        public class ParsedMethod
        {
            public string Namespace { get; set; } = "";
            public string ClassName { get; set; } = "";
            public string MethodName { get; set; } = "";
            public List<string> Parameters { get; set; } = [];


            public static ParsedMethod ParseMethodString(string input)
            {
                var result = new ParsedMethod();

                // 处理参数部分（可能不存在）
                int parenPos = input.IndexOf('(', StringComparison.OrdinalIgnoreCase);
                string beforeParen = input;
                string? paramsStr = default;

                if (parenPos != -1)
                {
                    beforeParen = input[..parenPos];
                    paramsStr = input[(parenPos + 1)..];
                    paramsStr = paramsStr[..paramsStr.IndexOf(')', StringComparison.OrdinalIgnoreCase)];
                }

                // 提取方法名和前面的部分
                int colonPos = beforeParen.IndexOf("::", StringComparison.OrdinalIgnoreCase);

                if (colonPos != -1)
                {
                    // 有::的情况（可能有AA.BB或BB）
                    string prefix = beforeParen[..colonPos];
                    result.MethodName = beforeParen[(colonPos + 2)..];

                    // 检查是否有AA.BB结构
                    int dotPos = prefix.IndexOf('.', StringComparison.OrdinalIgnoreCase);
                    if (dotPos != -1)
                    {
                        result.Namespace = prefix[..dotPos];
                        result.ClassName = prefix[(dotPos + 1)..];
                    }
                    else
                    {
                        result.ClassName = prefix;
                    }
                }
                else
                {
                    // 没有::的情况，整个就是方法名
                    result.MethodName = beforeParen;
                }

                // 处理参数
                if (!string.IsNullOrWhiteSpace(paramsStr))
                {
                    GetParamsStrings(paramsStr);
                    //paramsStr.Split([','], StringSplitOptions.RemoveEmptyEntries)
                    //.Select(p => p.Trim())
                    //.Where(p => !string.IsNullOrEmpty(p))
                    //.ToList();
                }

                return result;

                void GetParamsStrings(string paramsStr)
                {
                    var span = paramsStr.AsSpan();
                    foreach (var s in span.Split(','))
                    {
                        var next = paramsStr.AsSpan()[s];
                        next = next.Trim();
                        if (next.IsEmpty == false)
                        {
                            result.Parameters.Add(next.ToString());
                        }
                    }
                }
            }
        }



    }
}
