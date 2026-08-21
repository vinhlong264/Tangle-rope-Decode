using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.Collection
{
	public class OfferCollectionItemsSetup : CollectionItemsSetup
	{
		[Header("Config")]
		[FormerlySerializedAs("shopOfferItemsService")]
		[SerializeField]
		private CollectionOfferItemsService collectionOfferItemsService;

		protected override List<CollectionItemData> GetFilteredDataList(List<CollectionItemData> itemsData)
		{
			return null;
		}
	}
}
