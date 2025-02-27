
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_GET_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_GET_CLASS(nint ptr)
    {
        public const string il2cpp = "il2cpp_object_get_class";
        public const string mono = "mono_object_get_class";

        //nint MONO_OBJECT_GET_CLASS (void *object)
        //typedef void* (__cdecl *MONO_OBJECT_GET_CLASS)(void *object);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoClass>)ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoObject pMonoObject) => _func(pMonoObject);


    }



    #endregion



}