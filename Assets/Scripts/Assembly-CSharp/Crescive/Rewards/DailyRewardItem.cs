using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.Rewards
{
	public class DailyRewardItem : MonoBehaviour
	{
		[SerializeField]
		private GameObject lockedContent;

		[SerializeField]
		private GameObject unlockedContent;

		[SerializeField]
		private Image rewardIconImage;

		[SerializeField]
		private GameObject focus;

		[SerializeField]
		private GameObject collectedOverlay;

		[SerializeField]
		private StringVariableInstancer dayNumberText;

		[SerializeField]
		private StringVariableInstancer rewardInfoText;

		[SerializeField]
		private StringVariableInstancer focusText;

		[SerializeField]
		public UnityEvent<DailyRewardItem> OnCollect;

		[SerializeField]
		public UnityEvent OnCanCollect;

		[SerializeField]
		public UnityEvent OnCanNotCollect;

		[field: SerializeField]
		public BaseDailyRewardData RewardData { get; private set; }

		[field: SerializeField]
		public bool CanCollect { get; private set; }

		private bool IsCollected => false;

		private void CollectReward()
		{
		}

		public void SetData(int day, BaseDailyRewardData data)
		{
		}

		public void SetCollected(bool value)
		{
		}

		public void SetFocused(string text)
		{
		}

		public void SetUnfocused()
		{
		}

		public void SetCanCollect(bool value)
		{
		}

		public void TryToCollect()
		{
		}

		public void SetLocked(bool value)
		{
		}
	}
}
