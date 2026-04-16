#pragma once

#ifndef _WINDLL
#include <windows.h>
#include<vector>
#pragma comment(lib, "dobby.lib")

extern "C" {
	int DobbyHook(void* address, void* fake_func, void** out_origin_func);
}
struct InternalCallInfo {
	const char* name;
	const void* method;
};
std::vector<InternalCallInfo> g_InternalCalls(10240);
typedef void(__cdecl* MonoAddInternalCall_t)(const char* name, const void* method);
MonoAddInternalCall_t g_OriginalMonoAddInternalCall = nullptr;
void __cdecl HookedMonoAddInternalCall(const char* name, const void* method)
{
	g_InternalCalls.push_back({ name, method });


	if (g_OriginalMonoAddInternalCall) {
		g_OriginalMonoAddInternalCall(name, method);
	}
}

HMODULE WINAPI LoadMonoModule(HINSTANCE hModule)
{
	wchar_t FileName[MAX_PATH] = { 0 };
	wchar_t SysPath[MAX_PATH] = { 0 };
	wchar_t FullPath[MAX_PATH] = { 0 };
	GetModuleFileName(hModule, FileName, MAX_PATH);
	PathRemoveFileSpec(FileName);
	PathCombine(FullPath, FileName, L"MonoBleedingEdge\\EmbedRuntime\\mono-2.0-bdwgc.dll");
	//MessageBox(nullptr, FullPath, L"Info", MB_OK);
	return LoadLibrary(FullPath);



}

void InstallHook(HINSTANCE hModule) {
	//"mono-2.0-bdwgc.dll", "GameAssembly.dll", "libil2cpp.so"
	HMODULE hMono = LoadMonoModule(hModule);


	if (!hMono) {
		return;
	}



	FARPROC targetFunc = GetProcAddress(hMono, "mono_add_internal_call");
	if (!targetFunc) {
		return;
	}


	//OriginalMonoAddInternalCall = (MonoAddInternalCall_t)targetFunc;
	DobbyHook(targetFunc, HookedMonoAddInternalCall, (void**)&g_OriginalMonoAddInternalCall);



}

// 实现导出函数
extern "C" {

	size_t WINAPI GetInternalCallCount() {
		return g_InternalCalls.size();
	}

	BOOL WINAPI GetInternalCallAt(size_t index, const char** outName, const void** outMethod) {
		if (index >= g_InternalCalls.size())
			return FALSE;
		*outName = g_InternalCalls[index].name;
		*outMethod = g_InternalCalls[index].method;
		return TRUE;
	}


}
#endif // !_WINDLL
