using System.Collections.Generic;
using Crescive.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestRewardsViewController : MonoBehaviour
	{
		[SerializeField]
		private FlexibleGridLayoutGroup regularRewardsGrid;

		[SerializeField]
		private FlexibleGridLayoutGroup goldenPassRewardsGrid;

		[SerializeField]
		private CommonProductViewController regularProductView;

		[SerializeField]
		private CommonProductViewController goldenPassProductView;

		private void SetupRewards(List<string> regularRewards, List<string> goldenPassRewards)
		{
		}

		private void SetupRewardGrids(bool hasBothRewardLists)
		{
		}

		private void SetupRewardGrid(FlexibleGridLayoutGroup grid, bool hasBothRewardLists)
		{
		}

		public void Setup(List<string> regularRewards, List<string> goldenPassRewards)
		{
		}

		public void ResetView()
		{
		}
	}
}
