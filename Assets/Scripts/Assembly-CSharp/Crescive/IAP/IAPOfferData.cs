using System;

namespace Crescive.IAP
{
	[Serializable]
	public class IAPOfferData : ICloneable
	{
		public string Id;

		public string LastOfferDate;

		public int LastOfferLevel;

		public int LastOfferInterCount;

		public int DailyOfferCount;

		public int TotalOfferCount;

		public IAPOfferData()
		{
		}

		public IAPOfferData(IAPOfferData other)
		{
		}

		public IAPOfferData(string id)
		{
		}

		private bool CanOfferEarly(IAPOfferPopUpSettings settings, IAPCanOfferArgs args)
		{
			return false;
		}

		private bool IsLevelFrequencyValid(IAPOfferPopUpSettings settings, IAPCanOfferArgs args)
		{
			return false;
		}

		private bool IsInterFrequencyValid(IAPOfferPopUpSettings settings, IAPCanOfferArgs args)
		{
			return false;
		}

		private bool IsMinPaymentValid(IAPOfferPopUpSettings settings, IAPCanOfferArgs args)
		{
			return false;
		}

		private bool IsDailyShowLimitValid(IAPOfferPopUpSettings settings)
		{
			return false;
		}

		private bool IsTotalShowLimitValid(IAPOfferPopUpSettings settings)
		{
			return false;
		}

		public object Clone()
		{
			return null;
		}

		public void ResetDailyValues(string currentDate, int currentLevelNumber)
		{
		}

		public bool CanOffer(IAPOfferPopUpSettings settings, IAPCanOfferArgs args)
		{
			return false;
		}
	}
}
