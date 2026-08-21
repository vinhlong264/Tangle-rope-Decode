using System;

namespace Plinko
{
	[Serializable]
	public class PlinkoData
	{
		public int TokenCount;

		public int CurrencyCount;

		public bool IsFirstTimePopped;

		public bool IsTutorialDone;

		public bool IsRefreshTutorialDone;

		public int ItemsSinceLastRare;

		public int ItemsSinceLastUltraRare;

		public int TotalRefreshCount;

		public ProbabilityRewardRemote[] CurrentlySelectedShopItems;

		public bool IsEventPlaying => false;
	}
}
