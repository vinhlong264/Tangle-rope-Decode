using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.IAP;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	[DefaultExecutionOrder(1)]
	public class DynamicQuestProgressPopupController : BaseDynamicQuestPopupController
	{
		[SerializeField]
		private DynamicQuestRewardRowView rewardRowViewPrefab;

		[SerializeField]
		private Transform rewardRowsParent;

		[SerializeField]
		private IAPPurchaser goldenPassPurchaser;

		[SerializeField]
		private ScrollRect rewardsScrollRect;

		[SerializeField]
		private Button goldenPassButton;

		[SerializeField]
		private GameObject goldenPassButtonOverrideSortPivot;

		[SerializeField]
		private GameObject rewardsOverrideSortPivot;

		[SerializeField]
		private FloatSettableVariableReference rewardStepCount;

		[SerializeField]
		private FloatSettableVariableReference currentRewardStep;

		[SerializeField]
		private StringSettableVariableReference goldenPassId;

		[SerializeField]
		private List<DynamicQuestRewardRowView> rewardRows;

		public Button GoldenPassButton => null;

		public List<DynamicQuestRewardRowView> RewardRows => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void SetupRewardRows()
		{
		}

		private void SetupGoldenPassProductId()
		{
		}

		private void SnapToCurrentStep()
		{
		}

		protected override void SyncBindingsInternal()
		{
		}

		protected override void SetupInternal()
		{
		}

		protected override void ResetViewInternal()
		{
		}

		public bool IsRewardUnlocked(int step)
		{
			return false;
		}

		public bool IsRewardCurrent(int step)
		{
			return false;
		}

		public void InitiateGoldenPassPurchase()
		{
		}

		public void SetGoldenPassButtonOverrideSortCanvas(bool value)
		{
		}

		public void SetRewardsOverrideSortCanvas(bool value)
		{
		}
	}
}
