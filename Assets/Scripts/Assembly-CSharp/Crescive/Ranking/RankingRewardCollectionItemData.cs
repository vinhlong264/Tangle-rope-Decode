using System;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingRewardCollectionItemData : ICloneable
	{
		public string ItemId;

		public RankingRewardCollectionItemData(string itemId)
		{
		}

		public RankingRewardCollectionItemData(RankingRewardCollectionItemData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
