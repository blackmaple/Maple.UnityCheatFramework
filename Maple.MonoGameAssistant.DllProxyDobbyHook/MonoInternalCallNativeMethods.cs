using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.DllProxyDobbyHook
{

    public static partial class MonoInternalCallNativeMethods
    {

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(SuppressGCTransitionAttribute)])]
        [LibraryImport("*", EntryPoint = nameof(GetInternalCallCount))]
        private static partial nuint GetInternalCallCount();

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall),typeof(SuppressGCTransitionAttribute)])]
        [LibraryImport("*", EntryPoint = nameof(GetInternalCallAt))]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool GetInternalCallAt(nuint index, PtrOut<PtrUtf8Char> name, PtrOut<nint> method);

        //[UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(SuppressGCTransitionAttribute)])]
        //[LibraryImport("*", EntryPoint = nameof(GetInternalCallAt))]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static partial bool GetInternalCallAt2(nuint index, PtrOut<PtrUtf8Char> name, PtrOut<nint> method);

        private static bool GetInternalCallAtWarpper(nuint index, out PtrUtf8Char name, out nint method)
            => GetInternalCallAt(index, PtrOut<PtrUtf8Char>.FromOut(out name), PtrOut<nint>.FromOut(out method));

        private static IEnumerable<KeyValuePair<string, nint>> EnumInternalCallCollection()
        {
            var count = GetInternalCallCount();
            for (nuint i = 0; i < count; i++)
            {
                if (GetInternalCallAtWarpper(i, out var utf8name, out var method))
                {
                    var name = utf8name.ToString();
                    if (!string.IsNullOrEmpty(name))
                    {
                        yield return new KeyValuePair<string, nint>(name, method);
                    }
                }
            }
        }

        public static IReadOnlyDictionary<string, nint> GetInternalCallCollection()
        {
            return EnumInternalCallCollection().ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }
}
