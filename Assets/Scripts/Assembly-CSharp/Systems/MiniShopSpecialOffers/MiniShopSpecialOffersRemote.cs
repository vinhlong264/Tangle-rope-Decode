using System;

namespace Systems.MiniShopSpecialOffers
{
	[Serializable]
	public class MiniShopSpecialOffersRemote
	{
		public int Level;

		public bool IsEnabled;

		public SegmentedProduct[] SegmentedProducts;

		public int RefreshDayCount;

		public int EgoOfferProductIndex;

		public DateTime StartDate;
	}
}
