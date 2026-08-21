using System;
using Crescive.IAP;
using PersistentSO;
using SegmentedOffers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(SegmentedOfferProductGiver))]
public class SegmentedOfferStoreViewController : MonoBehaviour
{
	[SerializeField]
	private GameObject pivot;

	[SerializeField]
	private string segmentId;

	[SerializeField]
	private PersistentIntVariable tierPersistentIntVariable;

	[SerializeField]
	private PersistentBoolVariable tierPersistentBoolVariable;

	[SerializeField]
	private PersistentIntVariable buyCount;

	[SerializeField]
	private SegmentedOfferDataService dataService;

	[SerializeField]
	private IAPPurchaser _purchaser;

	[SerializeField]
	private Button buyButton;

	[SerializeField]
	private SegmentedOfferRewardsViewController RewardsViewController;

	private SegmentSettings _offer;

	private SegmentProduct _segmentProduct;

	private IAPStoreController _storeController;

	private SegmentedOfferProductGiver _giver;

	private bool _isInitialized;

	public UnityEvent<string> OnExpireSet;

	public UnityEvent<string> OnGetCurrency;

	public UnityEvent<string> OnGetPrice;

	public UnityEvent<string> BuyLimit;

	public Action<bool> OnStateChanged;

	private IAPStoreController StoreController => null;

	private SegmentedOfferProductGiver Giver => null;

	public string SegmentId => null;

	public int BuyCount => 0;

	public bool IsActive { get; private set; }

	private void Initialize()
	{
	}

	private void SetBuyCount()
	{
	}

	private void SetPriceText()
	{
	}

	private void SetTimer()
	{
	}

	private string ConvertTimestampToFormat(long timestamp)
	{
		return null;
	}

	public void SetState(bool isActive)
	{
	}

	private void OnBuyButtonClicked()
	{
	}

	private void OnBuyCountChanged(int buy)
	{
	}

	public void OnPurchaseSucceed()
	{
	}

	private void StartProductAnimation()
	{
	}
}
