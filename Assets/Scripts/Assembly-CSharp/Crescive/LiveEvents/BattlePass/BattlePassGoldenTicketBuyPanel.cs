using Crescive.IAP;
using Crescive.Navigation;
using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassGoldenTicketBuyPanel : MonoBehaviour
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private IAPPurchaser iapPurchaserButton;

		[SerializeField]
		private IAPProductListener iapProductListenerForPrice;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant goldenTicketPurchasedPanelId;

		private Navigatable? _navigatable;

		private Navigatable Navigatable => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ExecuteOnPurchaseFailedCallback(ElephantPaymentsError elephantPaymentsError)
		{
		}

		private void Setup()
		{
		}

		public void OnPurchaseClicked()
		{
		}

		private void HandlePurchaseCompleted(Product arg0)
		{
		}

		private void HandlePurchaseFailed(Product arg0, PurchaseFailureReason purchaseFailureReason)
		{
		}

		private void HandlePurchaseInitiated()
		{
		}
	}
}
