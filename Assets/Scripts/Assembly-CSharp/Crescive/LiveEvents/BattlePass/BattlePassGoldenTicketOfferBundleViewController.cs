using Crescive.IAP;
using Crescive.Navigation;
using Crescive.ResourceSystem;
using Crescive.Shop;
using Crescive.TwistedTangle.SingleLineProgression;
using ElephantSDK;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassGoldenTicketOfferBundleViewController : ShopBundleViewController
	{
		[SerializeField]
		private ResourceGeneratorDataService heartGeneratorDataService;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant goldenTicketClaimRewardsPanelId;

		[SerializeField]
		private IAPPurchaser iapPurchaserButton;

		[SerializeField]
		private IAPProductListener iapProductListenerForPrice;

		[SerializeField]
		private TextMeshProUGUI heartLimitText;

		[SerializeField]
		private InGameOfferDataService timeOutInGameOfferDataService;

		[SerializeField]
		private InGameOfferController inGameOfferController;

		[SerializeField]
		private TextMeshProUGUI extraTimeText;

		[SerializeField]
		private GameObject pivotObject;

		protected override bool ShowPropertiesEmptyInfo => false;

		public override string ItemId => null;

		public override bool IsDiscounted => false;

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		private void ExecuteOnPurchaseFailedCallback(ElephantPaymentsError elephantPaymentsError)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void OnDisable()
		{
		}

		public void OnClicked()
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

		private bool CheckToEnablePivot()
		{
			return false;
		}

		private void SetPivotActive(bool active)
		{
		}

		public override void Setup(string _)
		{
		}

		public override void ShowAmount(bool show)
		{
		}

		public override void SetAmount(int amount)
		{
		}

		protected override bool SyncBindings()
		{
			return false;
		}
	}
}
