using HarmonyLib;
using MiraAPI.Utilities.Assets;
using Eclipse.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace Eclipse.Patches;

[HarmonyPatch]
public static class LogoPatch
{
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.Banner), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Prefix(ref LoadableAsset<Sprite> __result)
    {
        __result = EclipseAssets.Banner;
        return false;
    }
}