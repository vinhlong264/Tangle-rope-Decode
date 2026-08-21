using System.Collections.Generic;
using Crescive.Boosters;
using Crescive.Collection;
using Crescive.DataService;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "RankingRewardsDataService", menuName = "Crescive/Ranking/RankingRewardsDataService")]
	public class RankingRewardsDataService : DataReadService<RankingRewardsData>
	{
		[SerializeField]
		private IntVariableReference levelNumber;

		[SerializeField]
		private List<RankingRewardClaimer> rewardClaimers;

		[Header("Reward Setup")]
		[SerializeField]
		private CollectionItemSystemsChannel collectionItemSystemsChannel;

		[SerializeField]
		private List<CollectionItemSystem> exceptedCollections;

		[SerializeField]
		private BoosterSystem boosterSystem;

		protected override RankingRewardsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(RankingRewardsData plainData)
		{
			return false;
		}

		public RankingRewardData GetRewardForRank(int rank)
		{
			return null;
		}

		public RankingRewardData SetupReward(RankingRewardData reward)
		{
			return null;
		}

		public void ClaimReward(RankingRewardData reward, Transform claimTransform)
		{
		}
	}
}
