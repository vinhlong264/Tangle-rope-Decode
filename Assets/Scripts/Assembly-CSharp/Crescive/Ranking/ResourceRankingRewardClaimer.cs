using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "ResourceRankingRewardClaimer", menuName = "Crescive/Ranking/ResourceRankingRewardClaimer")]
	public class ResourceRankingRewardClaimer : RankingRewardClaimer
	{
		[SerializeField]
		private ResourcesChannel resourcesChannel;

		public override void ClaimReward(RankingRewardData reward, Transform claimTransform)
		{
		}
	}
}
