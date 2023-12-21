using RimWorld;

namespace LoonyLadle.ButcherRotten
{
	[DefOf]
	public static class MyDefOf
	{
		static MyDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(MyDefOf));

		public static ThoughtDef LuluButcherRotten_ButcheredRotten;
	}
}
