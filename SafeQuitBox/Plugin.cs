using System;
using BepInEx;
using GorillaLocomotion;
using HarmonyLib;
using UnityEngine;

namespace SafeQuitBox
{
    [BepInPlugin("h4rns.fbg.safequitbox", "SafeQuitBox", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake() => new Harmony("h4rns.fbg.safequitbox").PatchAll();

        [HarmonyPatch(typeof(GorillaQuitBox), "OnBoxTriggered")]
        class GorillaQuitBoxPatch
        {
            static bool Prefix()
            {
                GTPlayer.Instance.TeleportTo(new Vector3(-66.8877f, 11.8749f, -82.43f), GTPlayer.Instance.transform.rotation, true);
                return false;
            }
        }
    }
}
