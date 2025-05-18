using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.GameShared.Service
{

    internal static class GameUIExtensions
    {
        private static MarkupString EmptyMarkupString { get; } = new MarkupString(nameof(string.Empty));
        public static MarkupString ToDisplayName(this GameDisplayDTO? gameDisplay)
        {

            if (gameDisplay is null || string.IsNullOrEmpty(gameDisplay.DisplayName))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameDisplay.DisplayName);
        }
        public static MarkupString ToDisplayDesc(this GameDisplayDTO? gameDisplay)
        {
            if (gameDisplay is null || string.IsNullOrEmpty(gameDisplay.DisplayDesc))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameDisplay.DisplayDesc);
        }
        public static MarkupString ToDisplayName(this GameValueInfoDTO gameValueInfo)
        {
            if (string.IsNullOrEmpty(gameValueInfo.DisplayName))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameValueInfo.DisplayName);
        }

        public static MarkupString ToDisplayValue(this GameValueInfoDTO gameValueInfo)
        {
            if (string.IsNullOrEmpty(gameValueInfo.DisplayValue))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameValueInfo.DisplayValue);
        }
        public static IEnumerable<T> GetItemAttributes<T>(this IReadOnlyList<T>? gameValueInfos, bool onlyPreview = false)
            where T : GameValueInfoDTO
        {

            if (gameValueInfos is not null)
            {
                foreach (var itemAtt in gameValueInfos)
                {
                    if (onlyPreview)
                    {
                        if (itemAtt.CanPreview)
                        {
                            yield return itemAtt;
                        }
                    }
                    else
                    {
                        yield return itemAtt;
                    }
                }
            }
        }

        public static bool MultipleIsActive(this GameSwitchDisplayDTO gameSwitch, GameValueInfoDTO gameValue)
        {
            var content = gameSwitch.ContentValue;
            if (string.IsNullOrEmpty(content))
            {
                return false;
            }
            var span = content.AsSpan();
            foreach (var s in span.Split(','))
            {
                if (span[s] == gameValue.DisplayValue)
                {
                    return true;
                }
            }
            return false;
        }
        public static string? MultipleAddActive(this GameSwitchDisplayDTO gameSwitch, GameValueInfoDTO gameValue)
        {
            var content = gameSwitch.ContentValue;
            if (string.IsNullOrEmpty(content))
            {
                 return gameValue.DisplayValue;
            }
            return string.Join(',', Active());

            IEnumerable<string?> Active()
            {
                foreach (var s in content.AsSpan().Split(','))
                {
                    if (content.AsSpan()[s] != gameValue.DisplayValue)
                    {
                        yield return content.AsSpan()[s].ToString();
                    }
                }
                yield return gameValue.DisplayValue;
            }
        }
        public static string? MultipleRemoveActive(this GameSwitchDisplayDTO gameSwitch, GameValueInfoDTO gameValue) 
        {
            var content = gameSwitch.ContentValue;
            if (string.IsNullOrEmpty(content))
            {
                return default;
            }
            return string.Join(',', Active());

            IEnumerable<string?> Active()
            {
                foreach (var s in content.AsSpan().Split(','))
                {
                    if (content.AsSpan()[s] != gameValue.DisplayValue)
                    {
                        yield return content.AsSpan()[s].ToString();
                    }
                }
                
            }


        }

        public static bool SelectedIsActive(this GameSwitchDisplayDTO gameSwitch, GameValueInfoDTO gameValue)
        {
            return gameSwitch.ContentValue == gameValue.DisplayValue;
        }

        public static bool ContainsGameDisplay(this GameDisplayDTO gameDisplay, string searchContent, string? displayCategory)
        {
            if (false == string.IsNullOrEmpty(gameDisplay.DisplayName) && gameDisplay.DisplayName.Contains(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (false == string.IsNullOrEmpty(gameDisplay.DisplayDesc) && gameDisplay.DisplayDesc.Contains(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (false == string.IsNullOrEmpty(displayCategory) && displayCategory.Contains(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }


        public static void ReplaceRange<T>(this List<T> list, IEnumerable<T> datas)
        {
            list.Clear();
            list.AddRange(datas);
        }

        public static UIProgressCircular ShowWait(this IPopupService popupService)
        {
            return new UIProgressCircular(popupService);
        }


        public static void SortArray<T>(this T[] datas) where T : GameObjectDisplayDTO
        {
            Array.Sort(datas, Comparer<T>.Create(static (x, y) =>
            {
                var cmp = string.Compare(x.DisplayCategory, y.DisplayCategory);
                if (cmp != 0)
                {
                    return cmp;
                }
                //cmp = string.Compare(x.ObjectId, y.ObjectId);
                //if (cmp != 0)
                //{
                //    return cmp;
                //}
                return string.Compare(x.DisplayName, y.DisplayName);
            }));
        }
    }

    public sealed class UIProgressCircular : IDisposable
    {
        IPopupService Service { get; }

        public UIProgressCircular(IPopupService service)
        {
            this.Service = service;
            this.Show();
        }
        public void Show()
        {
            this.Service.ShowProgressCircular();
        }
        public void Close()
        {
            this.Service.HideProgressCircular();
        }

        public void Dispose()
        {
            this.Service.HideProgressCircular();
        }
    }

}
