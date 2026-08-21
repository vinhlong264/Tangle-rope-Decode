using System;

namespace Crescive.IAP
{
	[Serializable]
	public struct IAPCanOfferArgs
	{
		public int Level;

		public int InterCount;

		public bool NoAdsPurchased;

		public IAPDataService IapDataService;

		public PersistentUserPayments UserPaymentData;

		public IAPCanOfferArgs(int level, int interCount, bool noAdsPurchased, IAPDataService iapDataService, PersistentUserPayments userPaymentData)
		{
			Level = 0;
			InterCount = 0;
			NoAdsPurchased = false;
			IapDataService = null;
			UserPaymentData = null;
		}
	}
}
