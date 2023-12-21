using HarmonyLib;
using Verse;

namespace LoonyLadle.ButcherRotten
{
	[StaticConstructorOnStartup]
	public static class MyStaticConstructor
	{
		static MyStaticConstructor()
		{
			Harmony harmony = new Harmony("rimworld.loonyladle.butcherrotten");
			harmony.PatchAll();
		}
	}
}
