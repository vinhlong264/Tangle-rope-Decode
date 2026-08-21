using System;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class BaseLadderOfferEventArgs
	{
		public LadderOfferData LadderOfferData;

		public BaseLadderOfferEventArgs(LadderOfferData ladderOfferData)
		{
		}
	}
}
