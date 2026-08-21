using System.Collections.Generic;
using Crescive.IAP;
using SegmentedOffers;
using UnityEngine;

namespace Crescive.Collection
{
	public class RegularCollectionItemsSetup : CollectionItemsSetup
	{
		[Header("Config")]
		[SerializeField]
		private CollectionOfferItemsService collectionOfferItemsService;

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private SegmentedOfferDataService segmentedOfferDataService;

		protected override List<CollectionItemData> GetFilteredDataList(List<CollectionItemData> itemsData)
		{
			return null;
		}

		private bool CheckIfNotOfferAndPremiumItem(CollectionItemData data)
		{
			return false;
		}
	}
}
