using System;
using System.Collections.Generic;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOffersData : ICloneable
	{
		public List<LadderOfferData> LadderOffers;

		public LadderOffersData(List<LadderOfferData> ladderOffers)
		{
		}

		public LadderOffersData(LadderOffersData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
