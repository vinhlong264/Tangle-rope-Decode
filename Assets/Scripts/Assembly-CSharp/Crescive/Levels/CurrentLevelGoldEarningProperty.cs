using Crescive.HelperTypes;
using Crescive.Scriptables;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Earning/CurrentLevelGoldEarningProperty")]
	public class CurrentLevelGoldEarningProperty : IntScriptableProperty
	{
		[SerializeField]
		private GoldEarningDataService goldEarningDataService;

		[SerializeField]
		private IntVariableReference remainingMoves;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
