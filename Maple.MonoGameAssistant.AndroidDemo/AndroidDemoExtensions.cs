using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.AndroidWebApi;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidDemo
{
    public static class AndroidDemoExtensions
    {
        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return AndroidWebApiExtensions.JNI_OnLoadImp(javaVM, reserved, p => p.CreateDefaultAndroidService(p => { }, p => { }));
        }
    }
}
