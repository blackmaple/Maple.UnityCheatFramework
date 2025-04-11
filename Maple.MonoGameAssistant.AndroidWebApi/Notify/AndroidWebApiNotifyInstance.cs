using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidWebApi
{



    internal readonly struct AndroidWebApiNotifyInstance(JLOCAL<JOBJECT> instance, AndroidWebApiNotifyReference reference)
        : IJavaClassLocalInstance<AndroidWebApiNotifyReference>
    {
        public JLOCAL<JOBJECT> JLocal { get; } = instance;

        public JOBJECT Instance => JLocal.Value;

        public AndroidWebApiNotifyReference Reference { get; } = reference;



        public static bool TryCreate(in JniEnvironmentContext jniEnvironmentContext, JWEAK<JOBJECT> ptr, out AndroidWebApiNotifyInstance callbackInstance)
        {
            Unsafe.SkipInit(out callbackInstance);
            if (jniEnvironmentContext.JNI_ENV.TryWeak2Local(ptr, out var localObj))
            {
                var metadata = AndroidWebApiNotifyMetadata.CreateMetadata(jniEnvironmentContext, localObj);
                var classRef = AndroidWebApiNotifyReference.CreateReference(jniEnvironmentContext, metadata);
                callbackInstance = new AndroidWebApiNotifyInstance(localObj, classRef);
                return true;
            }
            return false;
        }

        public JBOOLEAN Callback_Notify(JSTRING json) => this.Reference.Callback_Notify(this.Instance, json);
    }
}