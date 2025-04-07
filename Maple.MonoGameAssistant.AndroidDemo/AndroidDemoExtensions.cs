using Maple.MonoGameAssistant.AndroidCore.WebApi;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.AndroidWebApi;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidDemo
{
    public class AndroidDemoExtensions
    {
        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        internal static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return AndroidWebApiExtensions.JNI_OnLoadImp(javaVM, reserved, p =>
               {
                   p.Host = new AndroidWebApiService(settings => { }, services => { });
               });
        }
    }
}
