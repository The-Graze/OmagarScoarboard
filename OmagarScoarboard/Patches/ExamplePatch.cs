using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmagarScoarboard.Patches
{
    [HarmonyPatch(typeof(GorillaScoreboardSpawner))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    internal class sbSpawnerPatch
    {
        private static bool Prefix(GorillaScoreboardSpawner __instance)
        {
            return false;
        }
    }
    [HarmonyPatch(typeof(GorillaScoreboardSpawner))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class sbStart
    {
        private static bool Prefix(GorillaScoreboardSpawner __instance)
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(GorillaScoreboardSpawner))]
    [HarmonyPatch("OnJoinedRoom", MethodType.Normal)]
    internal class sbJoinPatch
    {
        private static bool Prefix(GorillaScoreboardSpawner __instance)
        {
            return false;
        }
    }
}
