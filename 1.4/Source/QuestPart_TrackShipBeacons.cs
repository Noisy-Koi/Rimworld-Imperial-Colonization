using RimWorld;
using RimWorld.Planet;
using Verse;

namespace ImperialColonization
{
    public class QuestPart_TrackShipBeacons : QuestPartActivable
    {
        public MapParent parent;
        public override void QuestPartTick()
        {
            base.QuestPartTick();
            if (parent.HasMap)
            {
                foreach (var beacon in parent.Map.listerThings.ThingsOfDef(ThingDefOf.ShipLandingBeacon))
                {
                    var comp = beacon.TryGetComp<CompShipLandingBeacon>();
                    foreach (var area in comp.LandingAreas)
                    {
                        if (area.Clear && area.Active)
                        {
                            QuestUtility.SendQuestTargetSignals(parent.questTags, "ShipLandingBeaconSetUp", parent.Named("SUBJECT"));
                            return;
                        }
                    }
                }
            }
        }
    }
}
