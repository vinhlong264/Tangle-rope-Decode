using System;

namespace Systems.MiniShopSpecialOffers
{
	[Serializable]
	public class MiniShopSpecialOffersData
	{
		public DateTime LastRefreshTime;

		public int[] RemainingCounts;

		public int AssignedSegmentTier;
	}
}
