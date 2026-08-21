using UnityEngine;

namespace ElephantSDK
{
	public static class ElephantTracker
	{
		public static bool IsElephantInitialized { get; private set; }

		static ElephantTracker()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void AutoLoad()
		{
		}
	}
}
