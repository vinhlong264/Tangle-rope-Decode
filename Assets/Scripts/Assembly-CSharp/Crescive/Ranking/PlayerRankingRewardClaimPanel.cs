using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	public class PlayerRankingRewardClaimPanel : MonoBehaviour
	{
		[SerializeField]
		private RankingRewardsDataService rewardsDataService;

		[SerializeField]
		private RankingEntryRewardPanel rewardPanel;

		private RankingEntryData playerEntry;

		private RankingRewardData playerReward;

		public UnityEvent OnHasReward;

		public UnityEvent OnHasNoReward;

		public void Initialize(int rank)
		{
		}

		public void ClaimReward()
		{
		}
	}
}
