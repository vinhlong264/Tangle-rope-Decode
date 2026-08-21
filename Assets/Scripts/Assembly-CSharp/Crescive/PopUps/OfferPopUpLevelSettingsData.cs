using System;

namespace Crescive.PopUps
{
	[Serializable]
	public class OfferPopUpLevelSettingsData
	{
		public bool Enable;

		public int FirstLevel;

		public int Interval;

		public OfferPopUpLevelSettingsData(bool enable, int firstLevel, int interval)
		{
		}

		public OfferPopUpLevelSettingsData(OfferPopUpLevelSettingsData other)
		{
		}
	}
}
