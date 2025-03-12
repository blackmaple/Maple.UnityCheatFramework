using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector
{

    [method: MonoCollectorFlag(EnumMonoCollectorFlag.ContextCtor)]
#pragma warning disable CS9113 // 参数未读。
    public abstract class MonoCollectorContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger, string apiVer = "202407222030") : IMonoMetadataCollector
#pragma warning restore CS9113 // 参数未读。
    {
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        //   public EnumMonoCollectorTypeVersion TypeVersion { get; } = typeVersion;
        public EnumMonoRuntimeType TypeVersion => RuntimeContext.RuntimeType;
        public ILogger Logger { get; } = logger;
        public string ApiVersion { get; } = apiVer;

        public MonoImageInfoDTO[] ImageInfoDTOs { get; } = [.. runtimeContext.EnumMonoImages()];

        public PMonoString T(string str) => RuntimeContext.GetMonoString(str);
        public MonoGCHandle<PMonoString> T2(string str) => RuntimeContext.CreateMonoGCHandle(RuntimeContext.GetMonoString(str));
        public PMonoString T(in ReadOnlySpan<char> str) => RuntimeContext.GetMonoString(str);
        public MonoGCHandle<PMonoString> T2(in ReadOnlySpan<char> str) => RuntimeContext.CreateMonoGCHandle(RuntimeContext.GetMonoString(str));


        [MonoCollectorFlag(EnumMonoCollectorFlag.Throw)]
        [DoesNotReturn]
        public static TContext ThrowIfVerNotFound<TContext>(EnumMonoCollectorTypeVersion typeVersion)
            where TContext : MonoCollectorContext
        {

            var errMsg = $"NOT FOUND VER:{typeVersion}";
            return MonoCollectorObjectException.Throw<TContext>(errMsg);
        }

        public bool TryGetClassInfo(MonoCollecotrClassSettings classSettings, [MaybeNullWhen(false)] out MonoCollectorClassInfo classInfo)
        {
            Unsafe.SkipInit(out classInfo);
            return ImageInfoDTOs.TryGetFirstImageInfo(classSettings.Utf8ImageName, out var imageInfoDTO)
                    && RuntimeContext.TryGetFirstClassInfo(imageInfoDTO, classSettings, out classInfo);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetClassInfo)]
        protected MonoCollectorClassInfo GetClassInfo(MonoCollecotrClassSettings classSettings)
        {
            if (ImageInfoDTOs.TryGetFirstImageInfo(classSettings.Utf8ImageName, out var imageInfoDTO) == false)
            {
                var errMsg = $"{nameof(GetClassInfo)}:{classSettings.ImageName}:NOT FOUND";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoCollectorClassInfo>(errMsg);
            }
            if (RuntimeContext.TryGetFirstClassInfo(imageInfoDTO, classSettings, out var classInfo) == false)
            {
                var errMsg = $"{nameof(GetClassInfo)}:{classSettings.ImageName}.{classSettings.Namespace}.{classSettings.ClassName}:NOT FOUND";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoCollectorClassInfo>(errMsg);
            }

            return classInfo;
        }

        public bool TryGetMethodPointer(MonoCollectorClassInfo classInfo, Func<MonoMethodInfoDTO, bool> math, out nint address)
        {
            Unsafe.SkipInit(out address);
            if (classInfo.MethodInfos.TryGetFirstMethodInfo(math, out var methodInfoDTO))
            {
                address = RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
                return address != nint.Zero;
            }
            return false;
        }
        public bool TryGetMethodPointer(MonoCollectorClassInfo classInfo, string methodName, out nint address)
            => TryGetMethodPointer(classInfo, (p) => p.Name == methodName, out address);

        public nint GetMethodPointer(MonoCollectorClassInfo classInfo, string methodName, Func<MonoMethodInfoDTO, bool> math)
        {
            if (false == classInfo.MethodInfos.TryGetFirstMethodInfo(math, out var methodInfoDTO))
            {
                var errMsg = $"{nameof(GetMethodPointer)}:{classInfo.ClassInfoDTO.FullName}.{methodName} NOT FOUND";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<nint>(errMsg);
            }
            var addr = RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            if (addr.Valid() == false)
            {
                var errMsg = $"{nameof(GetMethodPointer)}:{classInfo.ClassInfoDTO.FullName}.{methodName} ERROR ADDRESS";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<nint>(errMsg);
            }

            return addr;
        }

        public MonoStaticMethodInvoker GetStaticMethodInvoker(MonoCollectorClassInfo classInfo, string methodName, Func<MonoMethodInfoDTO, bool> math)
        {
            if (false == classInfo.MethodInfos.TryGetFirstMethodInfo(math, out var methodInfoDTO))
            {
                var errMsg = $"{nameof(GetStaticMethodInvoker)}:{classInfo.ClassInfoDTO.FullName}.{methodName} NOT FOUND";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoStaticMethodInvoker>(errMsg);
            }
            var addr = RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            if (addr.Valid() == false)
            {
                var errMsg = $"{nameof(GetStaticMethodInvoker)}:{classInfo.ClassInfoDTO.FullName}.{methodName} ERROR ADDRESS";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoStaticMethodInvoker>(errMsg);
            }
            return new MonoStaticMethodInvoker(methodInfoDTO.Pointer, addr);
        }
        public int GetMemberFieldOffset(MonoCollectorClassInfo classInfo, string? fieldName)
        {
            var memberInfo = classInfo.GetFirstMemberFieldInfo(fieldName);
            if (memberInfo is null)
            {
                var errMsg = $"{nameof(GetMemberFieldOffset)}:{classInfo.ClassInfoDTO.FullName}.{fieldName} NOT FOUND";
                Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<int>(errMsg);
            }
            return memberInfo.Offset;
        }




    }
}
