using Crescive.Collection;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "CollectionItemRankingRewardClaimer", menuName = "Crescive/Ranking/CollectionItemRankingRewardClaimer")]
	public class CollectionItemRankingRewardClaimer : RankingRewardClaimer
	{
		[SerializeField]
		private CollectionItemSystemsChannel collectionItemSystemsChannel;

		public override void ClaimReward(RankingRewardData reward, Transform claimTransform)
		{
		}
	}
}
