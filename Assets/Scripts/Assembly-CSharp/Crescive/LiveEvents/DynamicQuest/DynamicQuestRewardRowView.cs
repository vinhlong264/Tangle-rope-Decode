using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestRewardRowView : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestRewardRowItemView regularItem;

		[SerializeField]
		private DynamicQuestRewardRowItemView goldenPassItem;

		[SerializeField]
		private IntSettableVariableReference rewardStep;

		[SerializeField]
		private BoolSettableVariableReference isUnlocked;

		[SerializeField]
		private BoolSettableVariableReference isCurrent;

		[SerializeField]
		private BoolSettableVariableReference isGoldenPassEnabled;

		[SerializeField]
		private BoolSettableVariableReference isGoldenPassActive;

		[SerializeField]
		private BoolSettableVariableReference canPurchaseGoldenPass;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private DynamicQuestProgressPopupController owner;

		[SerializeField]
		private int step;

		public int Step => 0;

		public DynamicQuestRewardRowItemView RegularItem => null;

		public DynamicQuestRewardRowItemView GoldenPassItem => null;

		private void SetupData(DynamicQuestRewardRowSetupArgs args)
		{
		}

		private void SetupItems(DynamicQuestRewardRowSetupArgs args)
		{
		}

		private void OnClickGoldenPassItem()
		{
		}

		public void Setup(DynamicQuestRewardRowSetupArgs args)
		{
		}

		public void SyncBindings()
		{
		}
	}
}
