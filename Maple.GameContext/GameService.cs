﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
namespace Maple.GameContext
{
    public abstract class GameService<T_GAMECONTEXT>(
        ILogger logger,
        MonoRuntimeContext runtimeContext,
        MonoGameSettings gameSettings)
         : IMapleGameService, IWinMsgNotifyService,
        IUnityTaskScheduler<T_GAMECONTEXT>,
        IMonoTaskScheduler<T_GAMECONTEXT>,
        IGameWebApiControllers
        where T_GAMECONTEXT : MonoCollectorContext
    {
        protected virtual bool EnableService => true;
        public ILogger Logger { get; } = logger;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoGameSettings GameSettings { get; } = gameSettings;
        public MonoTaskScheduler Scheduler { get; } = new MonoTaskScheduler(runtimeContext);


        public required T_GAMECONTEXT GameContext { get; set; }
        public required UnityEngineContext UnityEngineContext { get; set; }
        public required HookWinMsgService Hook { set; get; }
        public required GameSwitchDisplayDTO[] ListGameSwitch { set; get; }

        public ValueTask DestroyService()
        {
            this.Scheduler.Dispose();
            return ValueTask.CompletedTask;
        }
        public ValueTask LoadService()
        {
            if (this.EnableService)
            {
                try
                {
                    this.LoadGameService();

                    this.HookWindowMessage();

                    this.LoadListGameSwitch();

                    this.TryAutoOpenUrl();
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("LoadService Error:{ex}", ex);
                }
            }


            return ValueTask.CompletedTask;

        }


        private void LoadGameService()
        {
            using (this.Logger.Running())
            {
                using (this.RuntimeContext.CreateAttachContext())
                {
                    this.GameContext = this.LoadGameContext();
                    this.UnityEngineContext = this.LoadUnityEngineContext();
                    this.Logger.LogInformation("LoadGameContext=>{game}", this.GameContext.BuildVersion);
                }
            }

        }
        protected abstract T_GAMECONTEXT LoadGameContext();
        protected virtual UnityEngineContext LoadUnityEngineContext()
            => new UnityEngineContext_IL2CPP(this.RuntimeContext, this.Logger);
        protected virtual GameSwitchDisplayDTO[] InitListGameSwitch()
            => [];
        protected void LoadListGameSwitch()
        {
            this.ListGameSwitch = InitListGameSwitch();
        }
        protected GameSwitchDisplayDTO? FindGameSwitch(string objectId)
            => this.ListGameSwitch.Where(p => p.ObjectId == objectId).FirstOrDefault();



        protected virtual void HookWindowMessage()
        {
            using (this.Logger.Running(nameof(HookWinMsgExtensions.CreateHookWinMsgService)))
            {
                this.Hook = HookWinMsgExtensions.CreateHookWinMsgService();
                var hookStatus = this.Hook.SetHook(this);
                this.Logger.LogInformation("HookWindowMessage=>{hookStatus}", hookStatus);
            }
        }
        protected virtual bool TryAutoOpenUrl()
        {
            using (this.Logger.Running())
            {
                var open = this.GameSettings.TryAutoOpenUrl(out var url);
                this.Logger.LogInformation("{method}=>{url}=>{open}", nameof(TryAutoOpenUrl), url, open);
                return open;
            }
        }



        #region KeyDown
        public ValueTask NotifyAsync(WinMsgNotifyDTO msgNotify)
        {
            return msgNotify.KeyCode switch
            {
                EnumVirtualKeyCode.VK_F1 => F1_KeyDown(),
                EnumVirtualKeyCode.VK_F2 => F2_KeyDown(),
                EnumVirtualKeyCode.VK_F3 => F3_KeyDown(),
                EnumVirtualKeyCode.VK_F4 => F4_KeyDown(),
                EnumVirtualKeyCode.VK_F5 => F5_KeyDown(),
                EnumVirtualKeyCode.VK_F6 => F6_KeyDown(),
                EnumVirtualKeyCode.VK_F7 => F7_KeyDown(),
                EnumVirtualKeyCode.VK_F8 => F8_KeyDown(),
                EnumVirtualKeyCode.VK_F9 => F9_KeyDown(),
                EnumVirtualKeyCode.VK_F10 => F10_KeyDown(),
                EnumVirtualKeyCode.VK_F11 => F11_KeyDown(),
                EnumVirtualKeyCode.VK_F12 => F12_KeyDown(),

                EnumVirtualKeyCode.VK_1 => Num1_KeyDown(),
                EnumVirtualKeyCode.VK_2 => Num2_KeyDown(),
                EnumVirtualKeyCode.VK_3 => Num3_KeyDown(),
                EnumVirtualKeyCode.VK_4 => Num4_KeyDown(),
                EnumVirtualKeyCode.VK_5 => Num5_KeyDown(),
                EnumVirtualKeyCode.VK_6 => Num6_KeyDown(),
                EnumVirtualKeyCode.VK_7 => Num7_KeyDown(),
                EnumVirtualKeyCode.VK_8 => Num8_KeyDown(),
                EnumVirtualKeyCode.VK_9 => Num9_KeyDown(),
                EnumVirtualKeyCode.VK_0 => Num0_KeyDown(),

                EnumVirtualKeyCode.VK_NUMPAD1 => Num1_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD2 => Num2_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD3 => Num3_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD4 => Num4_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD5 => Num5_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD6 => Num6_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD7 => Num7_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD8 => Num8_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD9 => Num9_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD0 => Num0_KeyDown(),

                _ => ValueTask.CompletedTask
            }; ;
        }
        protected virtual ValueTask F1_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F2_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F3_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F4_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F10_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F11_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F12_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num1_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num2_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num3_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num4_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num0_KeyDown()
        {
            return ValueTask.CompletedTask;

        }

        #endregion

        #region WebApi

        public virtual ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
            => GameException.Throw<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
                        => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");

        public virtual ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
                        => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");


        public virtual ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
            => GameException.Throw<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
            => GameException.Throw<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");




        public virtual ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
            => GameException.Throw<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");




        public virtual ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
            => GameException.Throw<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return new ValueTask<GameSwitchDisplayDTO[]>(this.ListGameSwitch);
        }

        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");


        #endregion
    }
}
