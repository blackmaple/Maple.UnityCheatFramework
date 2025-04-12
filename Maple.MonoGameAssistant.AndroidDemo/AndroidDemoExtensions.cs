


using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.AndroidWebApi;
using Microsoft.AspNetCore.Hosting;
using System.Runtime.InteropServices;

//var context = new AndroidWebApiContext(default!)
//{

//};
//context.Settings.Http = true;
//var webhost = AndroidWebApiServiceExtensions.AsRunWebApiService(context, services => { });
//webhost.Run();



namespace Maple.MonoGameAssistant.AndroidDemo;

public static class AndroidDemoExtensions
{
    [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
    internal static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
    {
        return Maple.MonoGameAssistant.AndroidWebApi.AndroidExtensions.JNI_OnLoadImp(javaVM, reserved, static api => api);
    }
}