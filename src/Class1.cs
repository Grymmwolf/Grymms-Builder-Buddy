// Grymm's Builder Buddy — v1.2
// Features:
//   • Build-anywhere during PlayerBuilder.State.PLACEMENT
//   • Terrain tool: footprint validation bypass (large areas)

using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using SSSGame;
using UnityEngine;

namespace GrymmsBuilderBuddy
{
    [BepInPlugin("com.grymm.askamods.builderbuddy", "Grymm's Builder Buddy", "1.2")]
    public class BuilderBuddyPlugin : BasePlugin
    {
        internal static ManualLogSource LogS;

        public override void Load()
        {
            LogS = Log;
            new Harmony("com.grymm.askamods.builderbuddy").PatchAll();
            Log.LogInfo("[BuilderBuddy] Loaded (minimal).");
        }
    }

    // Build-anywhere (structures) — only while placing
    internal static class Guard
    {
        public static bool IsPlacing(PlayerBuilder pb, Placement p)
        {
            return pb != null && p != null &&
                   pb.CurrentState == PlayerBuilder.State.PLACEMENT;
        }
    }

    [HarmonyPatch(typeof(PlayerBuilder), "set_BuildPlacement")]
    public static class PB_SetBuildPlacement
    {
        public static void Postfix(PlayerBuilder __instance, Placement value)
        {
            try { if (Guard.IsPlacing(__instance, value)) value.Validity = PlacementValidity.VALID; } catch { }
        }
    }

    [HarmonyPatch(typeof(PlayerBuilder), "get_BuildPlacement")]
    public static class PB_GetBuildPlacement
    {
        public static void Postfix(PlayerBuilder __instance, ref Placement __result)
        {
            try { if (Guard.IsPlacing(__instance, __result)) __result.Validity = PlacementValidity.VALID; } catch { }
        }
    }

    // Terrain brush: allow large selections by bypassing footprint validation
    // IL: private bool _ValidateFootprint(LayerMask objectsMask)
    [HarmonyPatch(typeof(DynamicDimensionsPlacementTool), "_ValidateFootprint")]
    [HarmonyPatch(new System.Type[] { typeof(LayerMask) })]
    public static class DynDim_ValidateFootprint_AlwaysTrue
    {
        public static void Postfix(ref bool __result) { __result = true; }
    }
}
