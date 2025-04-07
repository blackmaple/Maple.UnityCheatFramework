using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.AndroidCore.WebApi
{
    public class AndroidWebApiExtensions
    {
        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        internal static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return JNI_OnLoadImp(javaVM, reserved, static api => api.CreateDefaultAndroidService());
        }

        public static JINT JNI_OnLoadImp(PTR_JAVA_VM javaVM, JOBJECT reserved, Func<AndroidApiContext, AndroidApiContext> createService)
        {
            ApiContext = createService(AndroidApiContext.CreateContext(javaVM));

            if (ApiContext.VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(ApiAction), "(ILjava/lang/String;)Z", new Ptr_Func_ApiAction(&ApiAction));
            }
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

    }
}
