using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.PlayerPrefHelpers
{
	[CreateAssetMenu(menuName = "Crescive/PlayerPrefs/StringPlayerPrefProperty")]
	public class StringPlayerPrefProperty : StringScriptableProperty
	{
		[SerializeField]
		private string prefKey;

		protected override string GetValue()
		{
			return null;
		}
	}
}
