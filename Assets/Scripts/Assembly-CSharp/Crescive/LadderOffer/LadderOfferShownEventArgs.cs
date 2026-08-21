using System;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferShownEventArgs : BaseLadderOfferEventArgs
	{
		public bool ForceShown;

		public LadderOfferShownEventArgs(LadderOfferData ladderOfferData, bool forceShown)
			: base(null)
		{
		}
	}
}
