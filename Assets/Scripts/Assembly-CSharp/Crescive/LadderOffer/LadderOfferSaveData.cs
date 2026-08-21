using System;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferSaveData : ICloneable
	{
		public string Id;

		public int CurrentIndex;

		public LadderOfferSaveData(string id, int currentIndex)
		{
		}

		public LadderOfferSaveData(LadderOfferSaveData other)
		{
		}

		public LadderOfferSaveData(LadderOfferData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
