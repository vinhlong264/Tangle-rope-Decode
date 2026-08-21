using System;

namespace Crescive.Offer
{
	[Serializable]
	public class OfferEventArgs
	{
		public string OfferName;

		public OfferType OfferType;

		public OfferOpeningType OpeningType;

		public string CurrencyType;

		public float CurrencyAmount;

		public string ItemName;

		public float ItemAmount;

		public OfferEventArgs(string offerName, OfferType offerType, OfferOpeningType openingType, string currencyType, float currencyAmount, string itemName, float itemAmount)
		{
		}
	}
}
