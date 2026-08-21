using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Ranking
{
	public class SingleRankingEntryRewardPanelSetter : MonoBehaviour
	{
		[SerializeField]
		private RankingRewardsDataService rankingRewardsDataService;

		[SerializeField]
		private RankingEntryRewardPanel rankingEntryRewardPanel;

		[SerializeField]
		private IntReference rank;

		private void OnEnable()
		{
		}
	}
}
