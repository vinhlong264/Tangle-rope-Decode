using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Rewards
{
	public class DailyRewardPanel : MonoBehaviour
	{
		[SerializeField]
		private DailyRewardsData dailyRewardsData;

		[SerializeField]
		private DailyRewardStateDataPersistentVariable dailyRewardStateDataPersistent;

		[SerializeField]
		private GameObject allCollectedForNowIndicator;

		[SerializeField]
		private List<DailyRewardItem> items;

		[SerializeField]
		private int showRewardsAfterCollectedDayDaysCount;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToItems()
		{
		}

		private void UnsubscribeFromItems()
		{
		}

		private void OnCollectRewardItem(DailyRewardItem item)
		{
		}

		private void UpdateUI()
		{
		}
	}
}
