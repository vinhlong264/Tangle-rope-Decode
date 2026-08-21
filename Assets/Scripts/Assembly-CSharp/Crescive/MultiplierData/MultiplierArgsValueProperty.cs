using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.MultiplierData
{
	[CreateAssetMenu(fileName = "Multiplier Args Value Property", menuName = "Crescive/GameData/Multiplier/Multiplier Args Value Property")]
	public class MultiplierArgsValueProperty : FloatScriptableProperty
	{
		[SerializeField]
		private MultiplierArgs multiplierArgs;

		protected override float GetValue()
		{
			return 0f;
		}
	}
}
