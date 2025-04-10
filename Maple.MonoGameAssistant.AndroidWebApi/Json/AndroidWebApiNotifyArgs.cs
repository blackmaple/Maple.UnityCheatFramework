using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidWebApiNotifyArgs
    {
        public JGLOBAL<JSTRING> Json { get; init; }
        public JWEAK<JOBJECT> Instance { get; init; }
        public static AndroidWebApiNotifyArgs Create(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING json)
        {
            return new AndroidWebApiNotifyArgs()
            {
                Instance = jniEnv.NewWeakGlobalRef(instance),
                Json = jniEnv.NewGlobalRef(json)
            };
        }

        public void Release(in JniEnvironmentContext jniEnvironmentContext)
        {
            jniEnvironmentContext.JNI_ENV.DeleteWeakGlobalRef(this.Instance);
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(this.Json);
        }

    }
}
