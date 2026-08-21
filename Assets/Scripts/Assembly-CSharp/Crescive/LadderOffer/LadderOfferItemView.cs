using Crescive.IAP;
using Crescive.Shop;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.LadderOffer
{
	[DefaultExecutionOrder(1)]
	public class LadderOfferItemView : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private BaseShopBundleViewControllerSettings bundleViewControllerSettings;

		[SerializeField]
		private ShopBundlePackViewControllerSettings bundlePackViewControllerSettings;

		[SerializeField]
		private ShopProductsTypeSettings shopProductsTypeSettings;

		[SerializeField]
		private RectTransform productViewsParent;

		[Header("Override References")]
		[SerializeField]
		private BaseLadderOfferItemViewSettings itemViewSettings;

		[SerializeField]
		[Header("Animator")]
		private LadderOfferItemViewAnimator animator;

		[Header("Bindings")]
		[SerializeField]
		private BoolVariableInstancer isUnlocked;

		[SerializeField]
		private BoolVariableInstancer isClaimed;

		[SerializeField]
		private BoolVariableInstancer ownerCanClaim;

		[SerializeField]
		private Image itemBackgroundImage;

		[SerializeField]
		private Image contentBackgroundImage;

		[SerializeField]
		private LadderOfferView ownerView;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private Bundle itemBundle;

		[SerializeField]
		private int itemDataIndex;

		[SerializeField]
		private LadderOfferItemData itemData;

		[SerializeField]
		private LadderOfferItemViewSettingsResult itemViewSettingsResult;

		[Header("Events")]
		public UnityEvent OnSetupFinished;

		public UnityEvent<LadderOfferItemView> OnStartClaim;

		public UnityEvent<LadderOfferItemView> OnPerformClaim;

		public UnityEvent OnCanNotClaim;

		public LadderOfferItemViewAnimator Animator => null;

		public RectTransform ProductViewsParent => null;

		public LadderOfferView OwnerView => null;

		public bool DidSetData => false;

		public LadderOfferItemData ItemData => null;

		public int ItemDataIndex => 0;

		public bool CanClaim => false;

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SyncBindings()
		{
		}

		private void SetupOwner(LadderOfferView owner)
		{
		}

		private void SetupContent()
		{
		}

		private void SetupNestedBundle(Bundle bundle)
		{
		}

		private void SetupProduct(ProductInfo product)
		{
		}

		private void OnOwnerCanClaimChanged(bool _)
		{
		}

		private void OnAnyItemClaimFinished()
		{
		}

		public void Setup(LadderOfferView owner, LadderOfferItemData data, LadderOfferItemViewSetupArgs setupArgs)
		{
		}

		public void TryClaim()
		{
		}

		public void PerformClaim()
		{
		}
	}
}
