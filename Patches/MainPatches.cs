using HarmonyLib;
using Il2Cpp;


namespace AdjustableWalkSpeed.Patches
{
    internal class MainPatches
    {

        [HarmonyPatch(typeof(vp_FPSController), nameof(vp_FPSController.GetSlopeMultiplier))]

        public class MovementSpeedModifier
        {
            public static void Postfix(ref float __result, vp_FPSController __instance)
            {

                if (GameManager.GetPlayerManagerComponent().PlayerIsWalking())
                {
                    __result *= Main.walkSpeedMultiplier;
                }
                

                if (GameManager.GetPlayerManagerComponent().PlayerIsSprinting())
                {
                    __result *= Main.runSpeedMultiplier;
                }
            }
        }
    }
}
