using UnityEngine;

namespace Crescive.Ranking
{
	public abstract class RankingRewardClaimer : ScriptableObject
	{
		public abstract void ClaimReward(RankingRewardData reward, Transform claimTransform);
	}
}
