﻿using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;
namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector
{
    /// <summary>
    /// 源生成器约定请勿修改 可追加 2024年1月4日21点41分
    /// </summary>
    public partial class MonoCollectorMember
    {
        public MonoRuntimeContext RuntimeContext => CollectorContext.RuntimeContext;
        internal ILogger Logger => RuntimeContext.Logger;
        internal MonoCollectorContext CollectorContext { get; }
        public MonoCollectorClassInfo ClassInfo { get; }

        [MonoCollectorFlag(EnumMonoCollectorFlag.MemberCtor)]
        public MonoCollectorMember(MonoCollectorContext collectorContext, MonoCollectorClassInfo classInfo)
        {
            CollectorContext = collectorContext;
            ClassInfo = classInfo;
            InitMember();
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.InitMember)]
        protected virtual void InitMember() { }




        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMethodPointer)]
        protected nint GetMethodPointer(string methodName, Func<MonoMethodInfoDTO, bool> math)
            => CollectorContext.GetMethodPointer(ClassInfo, methodName, math);
        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMethodPointer)]
        protected nint GetMethodPointer(string methodName) => GetMethodPointer(methodName, (p) => p.Name == methodName);




        [MonoCollectorFlag(EnumMonoCollectorFlag.GetStaticMethodInvoker)]
        protected MonoStaticMethodInvoker GetStaticMethodInvoker(string methodName, Func<MonoMethodInfoDTO, bool> math)
            => CollectorContext.GetStaticMethodInvoker(ClassInfo, methodName, math);

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetStaticMethodInvoker)]
        protected MonoStaticMethodInvoker GetStaticMethodInvoker(string methodName)
            => GetStaticMethodInvoker(methodName, (p) => p.Name == methodName);

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMonoStaticFieldValue)]
        protected T_MonoObject GetMonoStaticFieldValue<T_MonoObject>(string staticFieldName)
            where T_MonoObject : unmanaged
        {
            return RuntimeContext.GetMonoStaticFieldValue<T_MonoObject>(ClassInfo, staticFieldName);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.TryGetModuleBaseAddress)]
        protected static bool TryGetModuleBaseAddress(string moduleName, out nint baseAddress)
        {
            Unsafe.SkipInit(out baseAddress);
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Contains(moduleName, StringComparison.OrdinalIgnoreCase))
                {
                    baseAddress = module.BaseAddress;
                    return true;
                }
            }
            return default;

        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetModuleBaseAddress)]
        public static nint GetModuleBaseAddress(string moduleName)
        {
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Contains(moduleName, StringComparison.OrdinalIgnoreCase))
                {
                    return module.BaseAddress;
                }
            }
            return default;
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject New<T_MonoObject>(bool execDefCtor)
            where T_MonoObject : unmanaged
        {
            return RuntimeContext.CreateMonoClass<T_MonoObject>(ClassInfo.ClassInfoDTO.Pointer, execDefCtor);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject Ctor<T_MonoObject>()
            where T_MonoObject : unmanaged
        {
            return RuntimeContext.CreateMonoClass<T_MonoObject>(ClassInfo.ClassInfoDTO.Pointer, true);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject IsFrom<T_MonoObject>(PMonoObject pMonoObject)
        where T_MonoObject : unmanaged
        {
            var pMonoClass = RuntimeContext.RuntiemProvider.GetMonoClass(pMonoObject);// pMonoObject.MonoClass;
            if (pMonoClass == ClassInfo.ClassInfoDTO.Pointer)
            {
                return pMonoObject.To<T_MonoObject>();
            }
            return default;
        }
        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject IsFrom<T_MonoObject>(nint pObj)
            where T_MonoObject : unmanaged
        {
            return IsFrom<T_MonoObject>(new PMonoObject(pObj));
        }


        [MonoCollectorFlag(EnumMonoCollectorFlag.NewArray)]
        public Span<T_ARRAY> NewArray<T_ARRAY>(int count, out PMonoArray ptrRawArray)
            where T_ARRAY : unmanaged
        {
            return RuntimeContext.CreateMonoArray<T_ARRAY>(ClassInfo.ClassInfoDTO.Pointer, count, out ptrRawArray);

        }

        public PMonoString T(string str) => RuntimeContext.GetMonoString(str);
        public PMonoString T(in ReadOnlySpan<char> str) => RuntimeContext.GetMonoString(str);

        public MonoGCHandle<T_MonoObject> GCNew<T_MonoObject>(bool execDefCtor)
            where T_MonoObject : unmanaged
        {
            var pMonoObject = RuntimeContext.CreateMonoClass<T_MonoObject>(ClassInfo.ClassInfoDTO.Pointer, execDefCtor);
            return new MonoGCHandle<T_MonoObject>(RuntimeContext, pMonoObject);
        }

        public Span<T_ARRAY> GCNewArray<T_ARRAY>(int count, out MonoGCHandle<PMonoArray> gchandle)
            where T_ARRAY : unmanaged
        {
            var ptrRawArray = RuntimeContext.CreateMonoArray(ClassInfo.ClassInfoDTO.Pointer, count);
            gchandle = new MonoGCHandle<PMonoArray>(RuntimeContext, ptrRawArray);
            return gchandle.Target.AsSpan<T_ARRAY>();
        }



        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMemberFieldOffset)]
        public int GetMemberFieldOffset(string? fieldName)
            => CollectorContext.GetMemberFieldOffset(ClassInfo, fieldName);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMemberFieldValue)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset)
            where T_FieldValue : unmanaged
        {
            ref var ref_Buffer = ref @this.AsRefStruct<byte>();
            ref var ref_Member = ref Unsafe.Add(ref ref_Buffer, fieldOffset);
            ref var ref_Value = ref Unsafe.As<byte, T_FieldValue>(ref ref_Member);
            return ref ref_Value;
        }

        public ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, string? fieldName)
            where T_FieldValue : unmanaged
        {
            var fieldOffset = GetMemberFieldOffset(fieldName);
            return ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
        }
        public void SetMemberFieldValue<T_FieldValue>(nint @this, string? fieldName, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldName);
            ref_Value = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [MonoCollectorFlag(EnumMonoCollectorFlag.SetMemberFieldValue)]
        public static void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
            ref_Value = value;
        }








    }
}
