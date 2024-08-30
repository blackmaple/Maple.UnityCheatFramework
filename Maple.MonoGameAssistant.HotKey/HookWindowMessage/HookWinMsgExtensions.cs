﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.WinApi;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.HotKey
{
    public static class HookWinMsgExtensions
    {
        

        public static IHookWinMsgService CreateHookWinMsgService()
        {
            using var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            var hWnd = currentProcess.MainWindowHandle;
            return new HookWinMsgService(hWnd);
        }


        internal static bool TryGetHookWindowMessage(this nint hWnd, [MaybeNullWhen(false)] out HookWinMsgService hookWindowMessage)
        {
            hookWindowMessage = default;
            if (TryGetWindowUserData(hWnd, out var pUserData))
            {
                return MapleObjectUnmanaged.TryGet(pUserData, out hookWindowMessage);
            }
            return false;
        }

        internal static bool TryGetWindowUserData(this nint hWnd, out nint pUserData)
        {
            pUserData = WindowsRuntime.GetWindowLongPtr(hWnd, EnumWindowLongPtrIndex.GWLP_USERDATA);
            return pUserData != nint.Zero;
        }

        internal static bool TrySetWindowUserData(this nint hWnd, nint pUserData, out nint pOldUserData)
        {
            Marshal.SetLastPInvokeError(0);
            pOldUserData = WindowsRuntime.SetWindowLongPtr(hWnd, EnumWindowLongPtrIndex.GWLP_USERDATA, pUserData);
            var lastError = Marshal.GetLastPInvokeError();
            return lastError == 0;
        }

    }
}
