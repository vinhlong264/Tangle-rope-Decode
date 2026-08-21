using System;
using UnityEngine.Serialization;

namespace Crescive.PlayerPrefHelpers
{
	[Serializable]
	public class PlayerPrefData
	{
		public enum PlayerPrefType
		{
			Int = 0,
			Float = 1,
			String = 2
		}

		[FormerlySerializedAs("Key")]
		public string Data;

		public PlayerPrefType Type;
	}
}
