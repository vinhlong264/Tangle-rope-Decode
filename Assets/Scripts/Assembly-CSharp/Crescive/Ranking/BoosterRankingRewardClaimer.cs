using Crescive.Boosters;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "BoosterRankingRewardClaimer", menuName = "Crescive/Ranking/BoosterRankingRewardClaimer")]
	public class BoosterRankingRewardClaimer : RankingRewardClaimer
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

		public override void ClaimReward(RankingRewardData reward, Transform claimTransform)
		{
		}
	}
}
