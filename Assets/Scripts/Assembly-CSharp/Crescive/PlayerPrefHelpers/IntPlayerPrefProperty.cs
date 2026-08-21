using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.PlayerPrefHelpers
{
	[CreateAssetMenu(menuName = "Crescive/PlayerPrefs/IntPlayerPrefProperty")]
	public class IntPlayerPrefProperty : IntScriptableProperty
	{
		[SerializeField]
		private string prefKey;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
