﻿using HarmonyLib;
using Verse;

namespace Cerespirin.ButcherRotten
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
