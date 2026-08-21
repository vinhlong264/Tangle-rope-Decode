using System;

namespace Crescive.PeriodicOffer
{
	[Serializable]
	public class PeriodicOfferData : ICloneable
	{
		public string OfferDate;

		public string Id;

		public float RemainingSeconds => 0f;

		public bool Offering => false;

		public PeriodicOfferData()
		{
		}

		public PeriodicOfferData(string offerDate, string id)
		{
		}

		public PeriodicOfferData(string id)
		{
		}

		public PeriodicOfferData(PeriodicOfferData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
