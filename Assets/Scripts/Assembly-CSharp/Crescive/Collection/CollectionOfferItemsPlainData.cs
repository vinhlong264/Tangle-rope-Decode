using System;
using System.Collections.Generic;

namespace Crescive.Collection
{
	[Serializable]
	public class CollectionOfferItemsPlainData
	{
		public List<string> ShopOfferItems;

		public List<string> CollectionOfferItems
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CollectionOfferItemsPlainData(CollectionOfferItemsPlainData data)
		{
		}
	}
}
