using System;
using ElephantSDK;

namespace Crescive.Offer
{
	[Serializable]
	public class OfferTestMetaData : ICloneable
	{
		public string TriggerPoint;

		public CurrencyAmount CurrencyAmount;

		public int TotalCurrencyTransactionAmount;

		public int SessionCurrencyTransactionAmount;

		public int TotalIAPCount;

		public int SessionIAPCount;

		public float TotalIAPLTV;

		public float SessionIAPLTV;

		public int TotalBossLevelStartedCount;

		public int SessionBossLevelStartedCount;

		public int TotalBossLevelCompletedCount;

		public int SessionBossLevelCompletedCount;

		public int TotalChallengeLevelStartedCount;

		public int SessionChallengeLevelStartedCount;

		public int TotalChallengeLevelCompletedCount;

		public int SessionChallengeLevelCompletedCount;

		public OfferTestMetaData(OfferTestMetaData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
