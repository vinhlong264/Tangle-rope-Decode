using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Ads
{
	public class RewardedResourceSpenderDelegateButton : RewardedResourceSpenderDelegate
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private bool autoToggleInteractable;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void Reset()
		{
		}

		private void OnButtonClicked()
		{
		}

		private void OnTrySpendCallback()
		{
		}

		private void OnSpendOperationFinishedCallback()
		{
		}
	}
}
