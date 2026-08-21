using System;
using System.Collections.Generic;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOffersSaveData : ICloneable
	{
		public List<LadderOfferSaveData> LadderOffers;

		public LadderOffersSaveData(List<LadderOfferSaveData> ladderOffers)
		{
		}

		public LadderOffersSaveData(LadderOffersSaveData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
