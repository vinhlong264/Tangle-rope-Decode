using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestProgressBarController : BaseDynamicQuestViewController
	{
		[SerializeField]
		private DynamicQuestProgressBarRewardViewController rewardView;

		[SerializeField]
		private RectTransform tokenPivot;

		[SerializeField]
		private Canvas overrideSortCanvas;

		[SerializeField]
		private FloatSettableVariableReference progress;

		[SerializeField]
		private FloatSettableVariableReference maxProgress;

		[SerializeField]
		private StringSettableVariableReference tokenNamePlural;

		[SerializeField]
		private BoolSettableVariableReference stepsFinished;

		[SerializeField]
		private Image tokenIcon;

		public DynamicQuestProgressBarRewardViewController RewardView => null;

		public RectTransform RewardPivot => null;

		public RectTransform TokenPivot => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void UpdateReward(int step)
		{
		}

		private void OnSaveDataChangedCallback(DynamicQuestData _)
		{
		}

		protected override void SyncBindingsInternal()
		{
		}

		public void IncreaseProgress(float value, int step, out int newStep)
		{
			newStep = default(int);
		}

		public void SetOnTop(bool value)
		{
		}
	}
}
