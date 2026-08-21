using System;

namespace Systems.MiniShopSpecialOffers
{
	[Serializable]
	public class ProductDetail
	{
		public string productID;

		public string productName;

		public int SegmentTier;

		public RewardList Rewards;

		public bool isExclusive;

		public int offerIconIndex;

		public int BuyLimit;
	}
}
