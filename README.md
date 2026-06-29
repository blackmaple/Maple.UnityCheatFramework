# Maple.UnityCheatFramework

Maple.UnityCheatFramework is a Unity game runtime interoperability framework focused on **C# AOT**, **Mono**, and **IL2CPP** scenarios.

Its goal is to help you build external tooling and runtime integrations for shipped Unity games **without depending on the Unity Editor or the original Unity project**.

## What this repository is for

This repository is designed for workflows such as:

- reading and modeling Unity game metadata
- bridging managed and native/runtime boundaries
- building game-specific adapters on top of shared infrastructure
- exposing runtime capabilities through desktop UI or Web APIs
- supporting multiple target platforms such as Windows and Android

In practice, this project is closer to a **runtime interop framework** than a traditional Unity gameplay plugin.

## NuGet

NuGet packages are published under the BlackMaple profile:

- https://www.nuget.org/profiles/BlackMaple

## Repository structure

The repository is organized into multiple projects with distinct responsibilities.

### Core and shared runtime layers

- `Maple.MonoGameAssistant.Core`
- `Maple.MonoGameAssistant.Common`
- `Maple.MonoGameAssistant.UnityCore`
- `Maple.MonoGameAssistant.Model`
- `Maple.MonoGameAssistant.Logger`

These projects provide common infrastructure, shared runtime utilities, Unity-facing abstractions, and reusable models.

### Game abstraction layers

- `Maple.MonoGameAssistant.GameCore`
- `Maple.MonoGameAssistant.GameShared`
- `Maple.MonoGameAssistant.GameDTO`
- `Maple.MonoGameAssistant.GameSSR`
- `Maple.MonoGameAssistant.GameWASM`

These projects support game-facing abstractions, DTOs, and higher-level integration surfaces.

### Metadata and collection pipeline

- `Maple.MonoGameAssistant.MetadataCollections`
- `Maple.MonoGameAssistant.MetadataExtensions`
- `Maple.MonoGameAssistant.MetadataSourceGenerator`
- `Maple.MonoGameAssistant.MetadataUnity`
- `Maple.MonoGameAssistant.MetadataDemo`
- `Maple.MonoGameAssistant.MonoCollector`
- `Maple.MonoGameAssistant.MonoCollectorDataV2`
- `Maple.MonoGameAssistant.MonoCollectorExtensionsV2`
- `Maple.MonoGameAssistant.MonoCollectorGeneratorV2`
- `Maple.MonoGameAssistant.MonoDataCollector`

These modules are oriented around metadata extraction, collection, code generation, and runtime data modeling.

### Platform integration

- `Maple.MonoGameAssistant.Windows`
- `Maple.MonoGameAssistant.AndroidCore`
- `Maple.MonoGameAssistant.AndroidJNI`
- `Maple.MonoGameAssistant.AndroidModel`

These projects provide platform-specific integration layers for Windows and Android runtimes.

### UI and external interfaces

- `Maple.MonoGameAssistant.UILogic`
- `Maple.MonoGameAssistant.WinForm`
- `Maple.MonoGameAssistant.WebApi`
- `Maple.MonoGameAssistant.WebApiLauncher`

These projects expose framework capabilities through user interfaces and service endpoints.

### Native/proxy components

- `Maple.MonoGameAssistant.DllProxyStaticLib`

This project likely supports native bridging or proxy-based integration scenarios.

## How to think about this project

If you are familiar with the Unity modding ecosystem, a useful mental model is:

- **BepInEx / MelonLoader** are typically used to load or inject code into a Unity game.
- **Maple.UnityCheatFramework** focuses more on what happens **after** you have runtime access: metadata, interop, modeling, platform bridges, tooling, and external interfaces.

That means this repository can complement loader-based approaches rather than replace them.

## Intended use cases

This framework may be useful when you want to:

- interact with Unity game runtime structures from external tooling
- support AOT-sensitive or IL2CPP-heavy environments
- create reusable game adapters instead of one-off scripts
- expose runtime data through APIs, desktop tools, or platform-specific bridges
- build a maintainable foundation for advanced Unity game tooling

## Cheat demos

### Win x64

- https://github.com/blackmaple/Maple.AzureValley
- https://github.com/blackmaple/Maple.Ghostmon
- https://github.com/blackmaple/Maple.Bloomtown
- https://github.com/blackmaple/Maple.TstdGame
- https://github.com/blackmaple/Maple.Nexomon

### Win x86

- https://github.com/blackmaple/Maple.CatQuest3

### Android arm64

- https://github.com/blackmaple/Maple.Nexomon
- https://github.com/blackmaple/Maple.TstdGame

### Android mod UI

- https://github.com/blackmaple/com.android.maple
- https://github.com/blackmaple/Android-Mod-Menu

## Getting started

Because this repository contains multiple projects and platform-specific components, the best way to start is:

1. open `Maple.MonoGameAssistant.slnx`
2. inspect the core projects first:
   - `Maple.MonoGameAssistant.Core`
   - `Maple.MonoGameAssistant.UnityCore`
   - `Maple.MonoGameAssistant.GameCore`
3. then review the metadata and collector projects
4. finally explore platform- or interface-specific projects such as Web API, WinForms, Windows, or Android

## Recommended next documentation steps

- add an architecture diagram
- document the startup or injection flow
- provide a minimal end-to-end example
- document Windows vs Android usage paths
- explain how Mono and IL2CPP scenarios differ in this framework

## License

MIT
