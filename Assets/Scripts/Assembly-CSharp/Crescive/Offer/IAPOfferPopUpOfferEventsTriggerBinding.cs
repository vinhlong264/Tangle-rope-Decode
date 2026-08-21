using Crescive.IAP;
using Crescive.Navigation;
using ElephantSDK;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.Offer
{
	[DefaultExecutionOrder(100)]
	public class IAPOfferPopUpOfferEventsTriggerBinding : BaseOfferPopUpOfferEventsTriggerBinding
	{
		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private IAPPurchaser iapPurchaser;

		protected override void OnEnable()
		{
		}

		private void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		private void SubscribeToIAPEvents()
		{
		}

		private void UnsubscribeFromIAPEvents()
		{
		}

		private void ExecuteOnPurchaseFailedCallback(ElephantPaymentsError elephantPaymentsError)
		{
		}

		private void OnShowCallback()
		{
		}

		private void OnPurchaseCompletedCallback(Product product)
		{
		}

		private void OnPurchaseFailedCallback(Product product, PurchaseFailureReason failureReason)
		{
		}

		protected override void OnApproveCallback()
		{
		}
	}
}
