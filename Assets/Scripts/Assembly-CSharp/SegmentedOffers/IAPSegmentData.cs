using System;

namespace SegmentedOffers
{
	[Serializable]
	public class IAPSegmentData
	{
		public float Price;

		public bool IsSegmentedOffer;

		public DateTime PurchaseDate;

		public string iapString;
	}
}
