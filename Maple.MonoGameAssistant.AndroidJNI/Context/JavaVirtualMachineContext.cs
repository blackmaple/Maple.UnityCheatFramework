﻿using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public sealed class JavaVirtualMachineContext(PTR_JAVA_VM javaVM)  
    {

        public const int JNI_VERSION_1_6 = 0x00010006;

        public PTR_JAVA_VM JAVA_VM { get; } = javaVM;
        public bool TryGetEnv(out JniEnvironmentContext jniEnvironmentContext)
        {
            Unsafe.SkipInit(out jniEnvironmentContext);
            if (JAVA_VM.GetEnv(out var jniEnv, JNI_VERSION_1_6))
            {
                jniEnvironmentContext = new JniEnvironmentContext(this, jniEnv);
                return true;
            }
            return false;
        }
        public bool TryAttachThread(out JniEnvironmentContext jniEnvironmentContext, [CallerMemberName] string threadName = nameof(TryAttachThread))
        {
            Unsafe.SkipInit(out jniEnvironmentContext);
            if (JAVA_VM.GetEnv(out var jniEnv, JNI_VERSION_1_6)
                || JAVA_VM.AttachCurrentThread(out jniEnv, JNI_VERSION_1_6, threadName))
            {
                jniEnvironmentContext = new JniEnvironmentContext(this, jniEnv);
                return true;
            }
            return false;
        }
        public bool TryAttachThreadAsDaemon(out JniEnvironmentContext jniEnvironmentContext, [CallerMemberName] string daemonName = nameof(TryAttachThreadAsDaemon))
        {
            Unsafe.SkipInit(out jniEnvironmentContext);
            if (JAVA_VM.GetEnv(out var jniEnv, JNI_VERSION_1_6)
                || JAVA_VM.AttachCurrentThreadAsDaemon(out jniEnv, JNI_VERSION_1_6, daemonName))
            {
                jniEnvironmentContext = new JniEnvironmentContext(this, jniEnv);
                return true;
            }
            return false;
        }
        public void DetachThread() => JAVA_VM.DetachCurrentThread();
        
    }

}
