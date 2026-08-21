using Crescive.Ads;
using Crescive.Navigation;
using UnityEngine;

namespace Crescive.Offer
{
	[DefaultExecutionOrder(100)]
	public class RWOfferPopUpOfferEventsTriggerBinding : BaseOfferPopUpOfferEventsTriggerBinding
	{
		[SerializeField]
		[Header("References")]
		private Navigatable navigatable;

		[SerializeField]
		private RewardedResourceSpenderDelegate rewardedResourceSpenderDelegate;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void SubscribeToRWEvents()
		{
		}

		private void UnsubscribeFromRWCallbacks()
		{
		}

		private void OnShowCallback()
		{
		}

		private void OnSpentCallback()
		{
		}

		private void OnSpentFailedCallback()
		{
		}

		protected override void OnApproveCallback()
		{
		}
	}
}
