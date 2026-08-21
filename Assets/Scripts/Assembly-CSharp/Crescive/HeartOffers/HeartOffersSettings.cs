using System;
using System.Collections.Generic;

namespace Crescive.HeartOffers
{
	[Serializable]
	public class HeartOffersSettings : ICloneable
	{
		public List<HeartOfferConfig> Offers;

		public HeartOffersSettings()
		{
		}

		public HeartOffersSettings(HeartOffersSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
