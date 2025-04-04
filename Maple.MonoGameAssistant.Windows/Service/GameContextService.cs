﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HookTask;
using Maple.MonoGameAssistant.Windows.HotKey;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service.HostedService;
using Maple.MonoGameAssistant.Windows.UITask;
using Maple.MonoGameAssistant.Windows.WinRT;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Windows.Service
{
    public abstract class GameContextService<T_CONTEXT>(
           ILogger logger,
           MonoRuntimeContext runtimeContext,
           MonoTaskScheduler monoTaskScheduler,
           MonoGameSettings gameSettings,
           HookWinMsgFactory hookWinMsgFactory)
        : IGameContextService,
        IWinMsgNotifyService,
        IHookTaskScheduler<T_CONTEXT>,
        IMonoTaskScheduler<T_CONTEXT>,
        IUITaskScheduler<T_CONTEXT>
        where T_CONTEXT : class, IMonoMetadataCollector
    {

        #region props


        public ILogger Logger { get; } = logger;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoGameSettings GameSettings { get; } = gameSettings;
        public TaskScheduler Scheduler { get; } = monoTaskScheduler;
        public HookWinMsgService Hook { get; } = hookWinMsgFactory.Create();

        public required T_CONTEXT Context { get; set; }
        public required IUnityPlayerNativeMethods? UnityEngineContext { get; set; }
        public required GameSwitchDisplayDTO[] ListGameSwitch { get; set; }

        public Exception? ServiceException { get; set; }
        #endregion

        #region Host Service



        public ValueTask StopAsync()
        {
            return ValueTask.CompletedTask;
        }
        public async ValueTask StartAsync()
        {
            using (Logger.Running())
            {
                try
                {
                    await LoadGameServiceAsync().ConfigureAwait(false);
                    await LoadGameDataAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Logger.LogError("LoadService Error:{ex}", ex);
                    this.ServiceException = ex;
                }
                try
                {

                    HookWindowMessage();

                    LoadListGameSwitch();

                    TryAutoOpenUrl();
                }
                catch (Exception ex)
                {
                    Logger.LogError("LoadService Error:{ex}", ex);
                }
            }




        }
        #endregion

        #region Init Service

        private async ValueTask LoadGameServiceAsync()
        {
            using (Logger.Running())
            {
                Context = await this.MonoTaskAsync((p, host) => host.LoadGameContext(), this).ConfigureAwait(false);
                Logger.LogInformation("LoadGameContext=>{ver}=>{api}", Context.TypeVersion, Context.ApiVersion);
                UnityEngineContext = await this.MonoTaskAsync((p, host) => host.TryLoadUnityEngineContext(), this).ConfigureAwait(false);
                Logger.LogInformation("LoadUnityEngineContext=>{load}=>{ver}=>{api}",
                    UnityEngineContext is not null,
                    UnityEngineContext?.TypeVersion,
                    UnityEngineContext?.ApiVersion);
            }
        }
        protected abstract T_CONTEXT LoadGameContext();
        protected abstract IUnityPlayerNativeMethods? LoadUnityEngineContext();
        protected IUnityPlayerNativeMethods? TryLoadUnityEngineContext()
        {
            try
            {
                return LoadUnityEngineContext();
            }
            catch (Exception ex)
            {
                Logger.LogError("{ex}", ex);
            }
            return default;
        }
        protected virtual GameSwitchDisplayDTO[] InitListGameSwitch()
            => [];
        private void LoadListGameSwitch()
        {
            ListGameSwitch = InitListGameSwitch();
        }

        protected GameSwitchDisplayDTO? FindGameSwitch(string objectId)
            => ListGameSwitch.Where(p => p.ObjectId == objectId).FirstOrDefault();



        protected virtual void HookWindowMessage()
        {
            using (Logger.Running())
            {
                var hookStatus = Hook.SetHook(this);
                Logger.LogInformation("HookWindowMessage=>{hookStatus}", hookStatus);
            }
        }
        protected virtual bool TryAutoOpenUrl()
        {
            using (Logger.Running())
            {
                var open = false;
                if (GameSettings.TryGetOpenUrl(out var url))
                {
                    open = WindowsRuntime.RunBrowser(url);
                }
                Logger.LogInformation("{method}=>{url}=>{open}", nameof(TryAutoOpenUrl), url, open);
                return open;
            }
        }


        protected virtual ValueTask LoadGameDataAsync()
        {
            return ValueTask.CompletedTask;
        }
        #endregion

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

                EnumVirtualKeyCode.VK_UP => Up_KeyDown(),
                EnumVirtualKeyCode.VK_DOWN => Down_KeyDown(),
                EnumVirtualKeyCode.VK_LEFT => Left_KeyDown(),
                EnumVirtualKeyCode.VK_RIGHT => Right_KeyDown(),




                EnumVirtualKeyCode.VK_A => A_KeyDown(),
                EnumVirtualKeyCode.VK_B => B_KeyDown(),
                EnumVirtualKeyCode.VK_C => C_KeyDown(),
                EnumVirtualKeyCode.VK_D => D_KeyDown(),
                EnumVirtualKeyCode.VK_E => E_KeyDown(),
                EnumVirtualKeyCode.VK_F => F_KeyDown(),
                EnumVirtualKeyCode.VK_G => G_KeyDown(),
                EnumVirtualKeyCode.VK_H => H_KeyDown(),
                EnumVirtualKeyCode.VK_I => I_KeyDown(),
                EnumVirtualKeyCode.VK_J => J_KeyDown(),
                EnumVirtualKeyCode.VK_K => K_KeyDown(),
                EnumVirtualKeyCode.VK_L => L_KeyDown(),
                EnumVirtualKeyCode.VK_M => M_KeyDown(),
                EnumVirtualKeyCode.VK_N => N_KeyDown(),
                EnumVirtualKeyCode.VK_O => O_KeyDown(),
                EnumVirtualKeyCode.VK_P => P_KeyDown(),
                EnumVirtualKeyCode.VK_Q => Q_KeyDown(),
                EnumVirtualKeyCode.VK_R => R_KeyDown(),
                EnumVirtualKeyCode.VK_S => S_KeyDown(),
                EnumVirtualKeyCode.VK_T => T_KeyDown(),
                EnumVirtualKeyCode.VK_U => U_KeyDown(),
                EnumVirtualKeyCode.VK_V => V_KeyDown(),
                EnumVirtualKeyCode.VK_W => W_KeyDown(),
                EnumVirtualKeyCode.VK_X => X_KeyDown(),
                EnumVirtualKeyCode.VK_Y => Y_KeyDown(),
                EnumVirtualKeyCode.VK_Z => Z_KeyDown(),
                EnumVirtualKeyCode.VK_ESCAPE => Escape_KeyDown(),
                EnumVirtualKeyCode.VK_TAB => Tab_KeyDown(),
                EnumVirtualKeyCode.VK_CAPITAL => CapsLock_KeyDown(),
                EnumVirtualKeyCode.VK_SHIFT => Shift_KeyDown(),
                EnumVirtualKeyCode.VK_CONTROL => Control_KeyDown(),
                EnumVirtualKeyCode.VK_MENU => Alt_KeyDown(),
                EnumVirtualKeyCode.VK_SPACE => Space_KeyDown(),
                EnumVirtualKeyCode.VK_RETURN => Enter_KeyDown(),
                EnumVirtualKeyCode.VK_BACK => Backspace_KeyDown(),

                EnumVirtualKeyCode.VK_HOME => Home_KeyDown(),
                EnumVirtualKeyCode.VK_END => End_KeyDown(),
                EnumVirtualKeyCode.VK_PRIOR => PageUp_KeyDown(),
                EnumVirtualKeyCode.VK_NEXT => PageDown_KeyDown(),
                EnumVirtualKeyCode.VK_SNAPSHOT => PrintScreen_KeyDown(),
                EnumVirtualKeyCode.VK_PAUSE => Pause_KeyDown(),
                _ => ValueTask.CompletedTask

            };
        }



        protected virtual ValueTask F1_KeyDown() => ValueTask.CompletedTask;
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


        protected virtual ValueTask Up_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Down_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Left_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Right_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask A_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask B_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask C_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask D_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask E_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask F_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask G_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask H_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask I_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask J_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask K_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask L_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask M_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask N_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask O_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask P_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Q_KeyDown() => ValueTask.CompletedTask;

        protected virtual ValueTask R_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask S_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask T_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask U_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask V_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask W_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask X_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Y_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Z_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Escape_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Tab_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask CapsLock_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Shift_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Control_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Alt_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Space_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Enter_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Backspace_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Home_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask End_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PageUp_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PageDown_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask PrintScreen_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask Pause_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        #endregion

        #region WebApi

        public virtual ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            if (this.ServiceException is not null)
            {
                return ValueTask.FromResult(GameException.Throw<GameSessionInfoDTO>($"Load Session Error {this.ServiceException.GetType().Name}:{this.ServiceException.Message}"));
            }
            var api = Context is not null ? Context.ApiVersion : "???";
            var data = GameSettings.GetGameSessionInfo(api);
            return ValueTask.FromResult(data);
        }

        public virtual ValueTask<GameSessionInfoDTO> LoadResourceAsync()
            => GetSessionInfoAsync();

        public virtual ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");

        public virtual ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.ThrowUIHide<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");



        public virtual ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
            => GameException.Throw<ValueTask<GameSkillDisplayDTO>>("NotImplemented");


        public virtual ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");




        public virtual ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return new ValueTask<GameSwitchDisplayDTO[]>(ListGameSwitch);
        }



        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");


        public void UpdateListGameImage<T>(IReadOnlyList<T> datas) where T : GameObjectDisplayDTO
            => UpdateListGameImage(datas, static p => $"{p.ObjectId}.png");

        public void UpdateListGameImage<T>(IReadOnlyList<T> datas, Func<T, string> func) where T : GameObjectDisplayDTO
        {
            foreach (var data in datas)
            {
                if (GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, func(data), out var url))
                {
                    data.DisplayImage = url;
                }
            }
        }



        #endregion
    }
}
