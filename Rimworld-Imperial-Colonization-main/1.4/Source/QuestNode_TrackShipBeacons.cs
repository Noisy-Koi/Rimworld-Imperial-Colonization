using HarmonyLib;
using RimWorld.Planet;
using RimWorld.QuestGen;
using Verse;

namespace ImperialColonization
{
    public class QuestNode_TrackShipBeacons : QuestNode
    {
        public SlateRef<string> inSignalEnable;

        public override bool TestRunInt(Slate slate)
        {
            if (slate.Get<Map>("map") == null)
            {
                return false;
            }
            return true;
        }

        public override void RunInt()
        {
            Slate slate = QuestGen.slate;
            var questPart = new QuestPart_TrackShipBeacons();
            questPart.inSignalEnable = QuestGenUtility.HardcodedSignalWithQuestID(inSignalEnable.GetValue(slate)) ?? slate.Get<string>("inSignal");
            questPart.parent = slate.Get<Site>("site");
            QuestGen.quest.AddPart(questPart);
        }
    }
}
