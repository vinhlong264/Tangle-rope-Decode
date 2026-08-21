using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Collection
{
	public class PremiumCollectionItemsSetup : CollectionItemsSetup
	{
		[SerializeField]
		[Header("Config")]
		private IAPDataService iapDataService;

		protected override List<CollectionItemData> GetFilteredDataList(List<CollectionItemData> itemsData)
		{
			return null;
		}
	}
}
