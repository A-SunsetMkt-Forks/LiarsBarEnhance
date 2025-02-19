﻿using HarmonyLib;
using LiarsBarEnhance.Components;

namespace LiarsBarEnhance.Features;

[HarmonyPatch]
public class SelectableLevelPatch
{
    [HarmonyPatch(typeof(Statsui), "Start")]
    [HarmonyPostfix]
    public static void StartPostfix(Statsui __instance)
    {
        __instance.gameObject.AddComponent<SelectableLevelController>();
        Plugin.Logger.LogDebug($"[{typeof(SelectableLevelPatch)}] Added {nameof(SelectableLevelController)} component to {__instance.gameObject.name}");
    }
}