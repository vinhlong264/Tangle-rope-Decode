using System.Collections.Generic;
using Crescive.IAP;
using Crescive.PopUps;
using PersistentSO;
using SegmentedOffers;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(SegmentedOfferProductGiver))]
public class SegmentedOfferView : MonoBehaviour
{
	[SerializeField]
	private SegmentedOfferDataService dataService;

	[SerializeField]
	private string segmentedOfferId;

	[SerializeField]
	private Button buyButton;

	[SerializeField]
	private IAPPurchaser _purchaser;

	[SerializeField]
	private OfferPopUp offerPopUp;

	[SerializeField]
	private PersistentIntVariable buyCount;

	[SerializeField]
	private PersistentIntVariable tierPersistentIntVariable;

	private SegmentProduct _segmentProduct;

	private SegmentedOfferProductGiver _giver;

	[SerializeField]
	private SegmentedOfferRewardsViewController RewardsViewController;

	private IAPStoreController _storeController;

	private SegmentSettings _offer;

	public UnityEvent<string> OnExpireSet;

	public UnityEvent<string> OnGetCurrency;

	public UnityEvent<string> OnGetPrice;

	public UnityEvent<string> BuyLimit;

	public UnityEvent<string> OnAnimationComplete;

	[SerializeField]
	private bool isThereSpineIcon;

	[SerializeField]
	private List<SpineAnimationKeyFrame> spineActionKeyFrames;

	[SerializeField]
	private SkeletonGraphic skeletonGraphic;

	[SpineAnimation(null, null, true, false, false)]
	public string idleAnimation;

	[SpineAnimation(null, null, true, false, false)]
	public string actionAnimation;

	private SegmentedOfferProductGiver Giver => null;

	private IAPStoreController StoreController => null;

	public void OnPurchaseSucceed()
	{
	}

	private void StartProductAnimation()
	{
	}

	public void OnShow()
	{
	}

	public void OnHide()
	{
	}

	private void Setup()
	{
	}

	private void OnBuyButtonClicked()
	{
	}

	private void SetPriceText()
	{
	}

	private void SetBuyCount()
	{
	}

	private void SetTimer()
	{
	}

	private string ConvertTimestampToFormat(long timestamp)
	{
		return null;
	}

	private void PlayActionThenIdle()
	{
	}

	private UnityEvent<string> PlayAnimation(string animationName)
	{
		return null;
	}

	private UnityEvent<string> AddAnimation(string animationName, bool loop = false, float delay = 0f)
	{
		return null;
	}

	private float? GetOverrideDelay(string animationName)
	{
		return null;
	}
}
