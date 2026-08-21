using System.Collections.Generic;
using Crescive.PlayerPrefHelpers;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class DropdownPlayerPrefGetter : MonoBehaviour
	{
		[SerializeField]
		private PlayerPrefList playerPrefList;

		[SerializeField]
		private CustomSearchableDropdown searchableDropdown;

		private void OnEnable()
		{
		}

		private void SetDropdown()
		{
		}

		private Dictionary<string, string> GetPlayerPrefsSaveData()
		{
			return null;
		}
	}
}
