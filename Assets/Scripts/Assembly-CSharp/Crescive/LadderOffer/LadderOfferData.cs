using System;
using System.Collections.Generic;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferData : ICloneable
	{
		public string Id;

		public List<LadderOfferItemData> Items;

		public LadderOfferData(string id, List<LadderOfferItemData> items)
		{
		}

		public LadderOfferData(LadderOfferData other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool HasItem(string itemId)
		{
			return false;
		}

		public int GetItemIndex(string itemId)
		{
			return 0;
		}
	}
}
