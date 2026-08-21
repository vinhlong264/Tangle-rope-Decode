using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class IAPOfferPopUpSettings : ICloneable
	{
		public bool Enabled;

		public string Id;

		public int Priority;

		public bool EarlyOffer;

		public int MinEarlyOfferLevel;

		public int MinEarlyOfferInterCount;

		public int MinOfferLevel;

		public int LevelFrequency;

		public int InterFrequency;

		public int MinPayment;

		public int DailyShowLimit;

		public int TotalShowLimit;

		private List<string> ProductIds => null;

		public IAPOfferPopUpSettings()
		{
		}

		public IAPOfferPopUpSettings(IAPOfferPopUpSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
