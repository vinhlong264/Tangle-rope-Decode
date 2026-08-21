using Crescive.LiveEvents.SuperPowerup;
using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.ConsecutiveWin
{
	[CreateAssetMenu(menuName = "Crescive/SuperPowerup/Conditions/RewardClaimedCondition")]
	public class ConsecutiveWinRewardClaimedCondition : AtomCondition
	{
		[SerializeField]
		private PersistentConsecutiveWinSaveData consecutiveWinSaveData;

		public override bool Call()
		{
			return false;
		}
	}
}
