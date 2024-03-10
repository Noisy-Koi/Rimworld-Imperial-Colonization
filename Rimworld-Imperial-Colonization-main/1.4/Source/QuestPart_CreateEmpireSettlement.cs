using RimWorld;
using RimWorld.Planet;
using Verse;

namespace ImperialColonization
{
    public class QuestPart_CreateEmpireSettlement : QuestPart
    {
        public string inSignal;

        public MapParent parent;

        public override void Notify_QuestSignalReceived(Signal signal)
        {
            if (!(signal.tag == inSignal))
            {
                return;
            }
            Settlement settlement = (Settlement)WorldObjectMaker.MakeWorldObject(WorldObjectDefOf.Settlement);
            settlement.SetFaction(Faction.OfEmpire);
            settlement.Tile = parent.Tile;
            settlement.Name = SettlementNameGenerator.GenerateSettlementName(settlement);
            Find.WorldObjects.Add(settlement);
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref inSignal, "inSignal");
            Scribe_References.Look(ref parent, "parent");
        }
    }
}
