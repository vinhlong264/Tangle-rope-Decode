using System.Collections.Generic;
using UnityEngine;

namespace Crescive.PlayerPrefHelpers
{
	[CreateAssetMenu(fileName = "PlayerPrefList", menuName = "Crescive/PlayerPrefs/PlayerPrefList", order = 0)]
	public class PlayerPrefList : ScriptableObject
	{
		[SerializeField]
		private List<PlayerPrefData> keysData;

		public List<PlayerPrefData> KeysData => null;
	}
}
