using RimWorld;
using RimWorld.Planet;
using RimWorld.QuestGen;

namespace ImperialColonization
{
    public class QuestNode_AddShipJob_Arrive : QuestNode_AddShipJob
    {
        public SlateRef<MapParent> mapParent;
        public override ShipJobDef DefaultShipJobDef => ShipJobDefOf.Arrive;

        public override void AddJobVars(ShipJob shipJob, Slate slate)
        {
            if (shipJob is ShipJob_Arrive shipJob_Arrive)
            {
                shipJob_Arrive.mapParent = mapParent.GetValue(slate);
            }
        }
    }
}
