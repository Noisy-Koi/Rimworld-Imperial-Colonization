using HarmonyLib;
using Verse;

namespace ImperialColonization
{
    public class ImperialColonizationMod : Mod
    {
        public ImperialColonizationMod(ModContentPack pack) : base(pack)
        {
			new Harmony("ImperialColonizationMod").PatchAll();
        }
    }
}
