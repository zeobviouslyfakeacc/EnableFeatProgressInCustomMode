using System;
using System.Reflection;
using Harmony;
using UnityEngine;

namespace EnableFeatProgressInCustomMode {
	internal static class Patches {

		public static void OnLoad() {
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			Debug.Log("[EnableFeatProgressInCustomMode] Version " + version + " loaded!");
		}

		[HarmonyPatch(typeof(Feat), "ShouldBlockIncrement")]
		private static class NeverBlockIncrement {
			private static void Postfix(ref bool __result) {
				__result = false;
			}
		}
	}
}
