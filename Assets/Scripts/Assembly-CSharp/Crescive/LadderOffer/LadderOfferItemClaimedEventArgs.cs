namespace Crescive.LadderOffer
{
	public class LadderOfferItemClaimedEventArgs : BaseLadderOfferEventArgs
	{
		public LadderOfferItemData LadderOfferItemData;

		public int Step;

		public LadderOfferItemClaimedEventArgs(LadderOfferData ladderOfferData, LadderOfferItemData ladderOfferItemData, int step)
			: base(null)
		{
		}
	}
}
