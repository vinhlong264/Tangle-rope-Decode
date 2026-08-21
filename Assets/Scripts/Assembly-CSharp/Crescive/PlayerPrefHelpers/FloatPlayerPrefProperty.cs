using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.PlayerPrefHelpers
{
	[CreateAssetMenu(menuName = "Crescive/PlayerPrefs/FloatPlayerPrefProperty")]
	public class FloatPlayerPrefProperty : FloatScriptableProperty
	{
		[SerializeField]
		private string prefKey;

		protected override float GetValue()
		{
			return 0f;
		}
	}
}
