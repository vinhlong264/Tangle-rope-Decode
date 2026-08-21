using Crescive.DataService;
using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionOfferItemsService", menuName = "Crescive/Collection/CollectionOfferItemsService")]
	public class CollectionOfferItemsService : DataReadService<CollectionOfferItemsPlainData>
	{
		protected override CollectionOfferItemsPlainData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(CollectionOfferItemsPlainData plainData)
		{
			return false;
		}
	}
}
