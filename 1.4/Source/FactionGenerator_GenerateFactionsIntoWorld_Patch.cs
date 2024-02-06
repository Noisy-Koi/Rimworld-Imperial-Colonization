using HarmonyLib;
using RimWorld;

namespace ImperialColonization
{
    [HarmonyPatch(typeof(FactionGenerator), "GenerateFactionsIntoWorld")]
    public static class FactionGenerator_GenerateFactionsIntoWorld_Patch
    {
        public static void Prefix()
        {
            FactionDefOf.Empire.hidden = true;
        }
        public static void Postfix()
        {
            FactionDefOf.Empire.hidden = false;
        }
    }
}
