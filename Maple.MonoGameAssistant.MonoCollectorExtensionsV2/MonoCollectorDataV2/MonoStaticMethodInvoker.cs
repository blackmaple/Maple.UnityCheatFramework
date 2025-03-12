using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2
{
#if SOURCE_GEN
    internal
#else 
    public
#endif
        readonly struct MonoStaticMethodInvoker
    {
        public readonly nint MonoMethod;
        public readonly nint PtrMethod;

        public MonoStaticMethodInvoker(nint monoMethod, nint func)
        {
            MonoMethod = monoMethod;
            PtrMethod = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>()
        {
            var tmp = PtrMethod;
            return Unsafe.As<nint, TFUNC>(ref tmp);
        }
    }
}
