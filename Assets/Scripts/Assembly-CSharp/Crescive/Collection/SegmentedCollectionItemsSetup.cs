using System.Collections.Generic;
using SegmentedOffers;
using UnityEngine;

namespace Crescive.Collection
{
	public class SegmentedCollectionItemsSetup : CollectionItemsSetup
	{
		[Header("Config")]
		[SerializeField]
		private SegmentedOfferDataService segmentedOfferDataService;

		[SerializeField]
		private CollectionItemSystemsChannel collectionItemSystemsChannel;

		protected override List<CollectionItemData> GetFilteredDataList(List<CollectionItemData> itemsData)
		{
			return null;
		}
	}
}
