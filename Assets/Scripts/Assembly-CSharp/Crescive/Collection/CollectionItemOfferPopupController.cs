using System.Collections.Generic;
using Crescive.Ads;
using PersistentSO;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Crescive.Collection
{
	public class CollectionItemOfferPopupController : BaseRWOfferPopupController
	{
		[FormerlySerializedAs("shopItemDataTypes")]
		[Header("References")]
		[SerializeField]
		private List<CollectionItemSystem> collectionItemDataTypes;

		[SerializeField]
		[FormerlySerializedAs("shopOfferItemsService")]
		private CollectionOfferItemsService collectionOfferItemsService;

		[FormerlySerializedAs("lastOfferedShopItemNumber")]
		[SerializeField]
		private PersistentIntVariable lastOfferedCollectionItemNumber;

		[FormerlySerializedAs("unlockedShopItems")]
		[SerializeField]
		private PersistentStringListVariable unlockedCollectionItems;

		[SerializeField]
		private RewardedResourceSpenderDelegate rewardedResourceSpender;

		[Header("UI References")]
		[SerializeField]
		private Image offerImage;

		[Header("Persistent")]
		[SerializeField]
		private PersistentBoolVariable offerItemAvailable;

		private bool didFindItem;

		private string itemIdToClaim;

		private void Awake()
		{
		}

		private void OnAwakeGetCollectionOfferItemsCallback(CollectionOfferItemsPlainData _)
		{
		}

		private void UpdateOfferItemAvailable()
		{
		}

		public void OnShow()
		{
		}

		public void OnApprove()
		{
		}

		public void UnlockLastOfferItem()
		{
		}
	}
}
