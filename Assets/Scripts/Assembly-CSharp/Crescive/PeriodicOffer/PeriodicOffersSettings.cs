using System;
using System.Collections.Generic;

namespace Crescive.PeriodicOffer
{
	[Serializable]
	public class PeriodicOffersSettings : ICloneable
	{
		public List<PeriodicOfferSettings> Offers;

		public PeriodicOffersSettings()
		{
		}

		public PeriodicOffersSettings(PeriodicOffersSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool HasOfferSettings(string id)
		{
			return false;
		}

		public PeriodicOfferSettings GetOfferSettings(string id)
		{
			return null;
		}
	}
}
