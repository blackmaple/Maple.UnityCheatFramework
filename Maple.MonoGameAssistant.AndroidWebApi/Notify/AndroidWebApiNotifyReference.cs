using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    internal readonly struct AndroidWebApiNotifyReference : IJavaClassReference<AndroidWebApiNotifyReference, AndroidWebApiNotifyMetadata>
    {
        public AndroidWebApiNotifyMetadata Metadata { get; init; }
        public PTR_JNI_ENV JNI_ENV { get; init; }

        public static AndroidWebApiNotifyReference CreateReference(in JniEnvironmentContext jniEnvironmentContext, AndroidWebApiNotifyMetadata metadata)
        {
            return jniEnvironmentContext.GetReference<AndroidWebApiNotifyReference, AndroidWebApiNotifyMetadata>(metadata);
        }

        public JBOOLEAN Callback_Notify(JOBJECT @this, JSTRING json) => this.Metadata.Callback_INFO(this.JNI_ENV, @this, json);

        public JSTRING GetConentRoot() => this.Metadata.GetContentRoot(this.JNI_ENV);
    }
}