using UnityEngine;
using UnityEngine.UI;

namespace DailyRewards
{
	public class MonthlyTargetUIController : MonoBehaviour
	{
		public MonthlyTargetUIElement[] MonthlyTargetUIElements;

		public Image FillImage;

		private RewardDisplayer rewardDisplayer;

		private DailyRewardsRemote dailyRewardsRemote;

		internal void SetData(RewardDisplayer rewardDisplayer, DailyRewardsRemote dailyRewardsRemote, bool[] isClaimedMonthlyArray, int monthDayProgression, ChestToolTip ChestToolTip)
		{
		}

		private void ClaimRewards(RewardList rewardList, int rewardIndex)
		{
		}

		private void OnMonthlyRewardClaimed(int rewardIndex)
		{
		}
	}
}
