using Il2Cpp;
using MelonLoader;
using Mono.Cecil;
using UnityEngine;

namespace AdjustableWalkSpeed
{
    internal sealed class Main : MelonMod
    {

        public static float walkSpeedMultiplier = 1;
        public static float runSpeedMultiplier = 1;

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Adjustable Walk Speed is online!");
            //Settings.OnLoad();
        }

        public override void OnUpdate()
        {

            //testing

            if (Input.mouseScrollDelta.y < 0 && !InterfaceManager.IsOverlayActiveCached())
            {
                walkSpeedMultiplier -= 0.1f;
                walkSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 3);

                runSpeedMultiplier -= 0.1f;
                runSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 3);
            }

            if (Input.mouseScrollDelta.y > 0 && !InterfaceManager.IsOverlayActiveCached())
            {
                walkSpeedMultiplier += 0.1f;
                walkSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 3);

                runSpeedMultiplier += 0.1f;
                runSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 3);
            }

        }

    }
}
