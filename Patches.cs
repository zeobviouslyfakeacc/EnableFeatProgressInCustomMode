using MelonLoader;
using Harmony;
using UnityEngine;

namespace EnableFeatProgressInCustomMode {
	internal class Mod : MelonMod {
		public override void OnApplicationStart() {
			Debug.Log($"[{InfoAttribute.Name}] version {InfoAttribute.Version} loaded!");
		}
	}

	internal static class Patches {

		[HarmonyPatch(typeof(Feat), "ShouldBlockIncrement")]
		private static class NeverBlockIncrement {
			private static void Postfix(ref bool __result) {
				__result = false;
			}
		}
	}
}
