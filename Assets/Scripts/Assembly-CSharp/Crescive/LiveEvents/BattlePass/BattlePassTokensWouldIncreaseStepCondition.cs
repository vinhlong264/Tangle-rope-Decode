using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(menuName = "Crescive/BattlePass/Conditions/TokensWouldIncreaseStep")]
	public class BattlePassTokensWouldIncreaseStepCondition : AtomCondition
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
