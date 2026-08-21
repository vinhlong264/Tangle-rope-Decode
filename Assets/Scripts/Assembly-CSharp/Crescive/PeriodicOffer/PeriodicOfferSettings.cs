using System;

namespace Crescive.PeriodicOffer
{
	[Serializable]
	public class PeriodicOfferSettings : ICloneable
	{
		public string Id;

		public int PeriodDays;

		public int PeriodHours;

		public int PeriodMinutes;

		public float GetTotalSeconds()
		{
			return 0f;
		}

		public PeriodicOfferSettings()
		{
		}

		public PeriodicOfferSettings(string id, int periodDays, int periodHours, int periodMinutes)
		{
		}

		public PeriodicOfferSettings(PeriodicOfferSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
