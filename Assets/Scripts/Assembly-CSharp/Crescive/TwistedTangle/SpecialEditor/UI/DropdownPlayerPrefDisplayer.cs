using System.Collections.Generic;
using Crescive.PlayerPrefHelpers;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class DropdownPlayerPrefDisplayer : MonoBehaviour
	{
		[SerializeField]
		private PlayerPrefList playerPrefList;

		[SerializeField]
		private TextMeshProUGUI displayText;

		private Dictionary<string, string> GetPlayerPrefsSaveData()
		{
			return null;
		}

		public void DisplaySelectedText(string key)
		{
		}
	}
}
