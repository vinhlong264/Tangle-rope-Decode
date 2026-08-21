using System;

namespace Crescive.IAP
{
	[Serializable]
	public class LimitedOfferData : ICloneable
	{
		public bool Offering;

		public string ProductId;

		public bool HasExpireDate;

		public string ExpireDate;

		public int TotalOfferCount;

		public bool IsExpired => false;

		public float RemainingSeconds => 0f;

		public LimitedOfferData()
		{
		}

		public LimitedOfferData(bool offering, string productId, string expireDate, int totalOfferCount, int totalPurchaseCount)
		{
		}

		public LimitedOfferData(LimitedOfferData other)
		{
		}

		public LimitedOfferData(LimitedOfferSettings settings)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
