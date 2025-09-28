using RimWorld;
using Verse;

namespace Cerespirin.ButcherRotten
{
	public class SpecialThingFilterWorker_Rotten : SpecialThingFilterWorker
	{
		public override bool Matches(Thing t)
		{
			return t.TryGetComp(out CompRottable compRottable) && !compRottable.PropsRot.rotDestroys && compRottable.Stage == RotStage.Rotting;
		}

		public override bool CanEverMatch(ThingDef def)
		{
			CompProperties_Rottable compProperties = def.GetCompProperties<CompProperties_Rottable>();
			return compProperties != null && !compProperties.rotDestroys;
		}
	}
}
