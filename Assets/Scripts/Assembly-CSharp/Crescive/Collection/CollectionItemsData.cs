using System;
using System.Collections.Generic;

namespace Crescive.Collection
{
	[Serializable]
	public class CollectionItemsData
	{
		public List<CollectionItemData> Items;

		public CollectionItemsData(CollectionItemsData other)
		{
		}
	}
}
