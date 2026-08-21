using System;
using System.Collections.Generic;
using Crescive.Boosters;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingRewardData : ICloneable
	{
		public List<RankingRewardResourceData> Resources;

		public List<RankingRewardCollectionItemData> CollectionItems;

		public List<RankingRewardBoosterData> Boosters;

		public int RandomCollectionItemCount;

		public int RandomBoosterCount;

		public RankingRewardData(RankingRewardData other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public List<RankingRewardBoosterData> GetAvailableBoosters(BoosterSystem boosterSystem)
		{
			return null;
		}
	}
}
