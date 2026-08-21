using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class IAPOffersData
	{
		public List<IAPOfferData> Offers;

		public IAPOffersData(IAPOffersData other)
		{
		}
	}
}
