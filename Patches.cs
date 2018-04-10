using Harmony;
using UnityEngine;

namespace EnableFeatProgressInCustomMode {
	internal class Patches {

		public static void OnLoad() {
			Debug.Log("[EnableFeatProgressInCustomMode] Loaded!");
		}

		[HarmonyPatch(typeof(Feat), "ShouldBlockIncrement")]
		private static class NeverBlockIncrement {
			private static void Postfix(ref bool __result) {
				__result = false;
			}
		}
	}
}
