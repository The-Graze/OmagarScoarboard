using BepInEx;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using UnityEngine;
using Utilla;

namespace OmagarScoarboard
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class ModIniter : BaseUnityPlugin
    {
        ModIniter()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void Start()
        {
            using (Stream str = Assembly.GetExecutingAssembly().GetManifestResourceStream("OmagarScoarboard.prefab"))
            {

            }
        }
    }
}
