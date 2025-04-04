﻿using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.AndroidModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;

namespace Maple.MonoGameAssistant.AndroidJNI.Classes
{


    public readonly ref struct AndroidToastReference : IJavaClassReference<AndroidToastReference, AndroidToastMetadata>
    {
        public AndroidToastMetadata Metadata { get; init; }
        public PTR_JNI_ENV JNI_ENV { get; init; }

        public unsafe void Show(JOBJECT context, ReadOnlySpan<char> content, bool showLong = true)
        {
            const int LENGTH_LONG = 1;
            const int LENGTH_SHORT = 0;
            var jTime = new JINT(showLong ? LENGTH_LONG : LENGTH_SHORT);
            var jString = JNI_ENV.CreateStringUnicode(content);
            var jObject = JNI_ENV.CallStaticObjectMethod(Metadata.GlobalClass, Metadata.METHOD_MAKETEXT, context, jString, jTime);
            JNI_ENV.CallVoidMethod(jObject, Metadata.METHOD_SHOW);
            JNI_ENV.DeleteLocalRef(jString);
            JNI_ENV.DeleteLocalRef(jObject);
        }


        public static AndroidToastReference CreateReference(in JniEnvironmentContext jniEnvironmentContext)
        {
            return jniEnvironmentContext.GetReference<AndroidToastReference, AndroidToastMetadata>(AndroidToastMetadata.CreateMetadata(jniEnvironmentContext));
        }

    }

}
