using System;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferItemViewSetupArgs
	{
		public int Index;

		public int LastIndex;

		public int DisplayCount;

		public bool IsHidden;

		public bool IsClaimed;

		public LadderOfferItemViewSetupArgs(int index, int lastIndex, int displayCount, bool isHidden, bool isClaimed)
		{
		}
	}
}
