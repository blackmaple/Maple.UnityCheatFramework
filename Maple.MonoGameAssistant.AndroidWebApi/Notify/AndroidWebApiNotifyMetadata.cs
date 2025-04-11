using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    internal sealed class AndroidWebApiNotifyMetadata : JavaClassMetadata<AndroidWebApiNotifyMetadata>
    {
        JMETHODID m_Method_Notify;

        protected sealed override void FindMethods(in JniEnvironmentContext context)
        {
            var methodDesc = "(Ljava/lang/String;)Z\0"u8;
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "Notify\0"u8, methodDesc, out m_Method_Notify);

        }

        public JBOOLEAN Callback_Notify(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, m_Method_Notify, json);


    }
}