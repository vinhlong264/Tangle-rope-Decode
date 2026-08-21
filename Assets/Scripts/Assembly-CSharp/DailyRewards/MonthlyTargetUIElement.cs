using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DailyRewards
{
	public class MonthlyTargetUIElement : MonoBehaviour
	{
		public float ReachFillRate;

		public int ProgressionTarget;

		public GameObject CheckMark;

		public GameObject DayTargetText;

		public GameObject Shine;

		public Button ClaimButton;

		public Image ClaimButtonImage;

		public GameObject RewardSpine;

		private int rewardIndex;

		private Action onClaimed;

		private Action onShowTooltip;

		private bool isReached;

		private bool isClaimed;

		private Sequence chestAnim;

		public void SetData(bool isClaimed, bool isReached, int rewardIndex, Action onClaimed, Action onShowTooltip)
		{
		}

		private void OnDisable()
		{
		}

		private void OnRewardClaimed()
		{
		}
	}
}
