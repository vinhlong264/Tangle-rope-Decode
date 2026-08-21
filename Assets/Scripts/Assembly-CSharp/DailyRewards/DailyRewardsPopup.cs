using Crescive.Navigation;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace DailyRewards
{
	public class DailyRewardsPopup : MonoBehaviour
	{
		public MonthlyTargetUIController MonthlyTargetUIController;

		public RewardDisplayer RewardDisplayer;

		public DailyRewardsTutorialController DailyRewardsTutorialController;

		public DailyRewardsDayUIElement[] DailyRewardsDayUIElements;

		public Navigatable dailyRewardsNavigatable;

		public Button CloseButton;

		public Button CloseButton2;

		public ChestToolTip ChestToolTip;

		public Transform AnimationIcon;

		public Transform AnimationTarget;

		private int dayIndex;

		private DailyRewardsRemote dailyRewardsRemote;

		public Sprite SilverChestIcon;

		public Sprite GoldChestIcon;

		public Sprite DiamondChestIcon;

		public SkeletonDataAsset SilverChestSkeletonAssetData;

		public SkeletonDataAsset GoldChestSkeletonAssetData;

		public SkeletonDataAsset DiamondChestSkeletonAssetData;

		private Sequence monthlyProgressionSequence;

		public void OpenDailyRewards(DailyRewardsRemote dailyRewardsRemote, bool[] isClaimedWeeklyArray, bool[] isClaimedMonthlyArray, int monthDayProgression, int dayIndex, bool isFirstTime)
		{
		}

		public void UpdateUI(bool[] isClaimedWeeklyArray, bool[] isClaimedMonthlyArray, int monthDayProgression)
		{
		}

		public void OpenChest(RewardList rewardList, int day, DailyRewardsDayUIElement dailyRewardsDayUIElement, Vector3 position)
		{
		}

		public void ClaimRewards(RewardList rewardList, int day)
		{
		}

		private void OnDailyRewardClaimed(int day)
		{
		}

		public void PlayMonthlyProgressionAnimation(int day)
		{
		}

		private void OnShowTooltip(RewardList rewardList, Vector3 position)
		{
		}

		public void CloseDailyRewards()
		{
		}
	}
}
