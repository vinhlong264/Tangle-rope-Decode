using System;
using System.Collections.Generic;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingRewardsData : ICloneable
	{
		public List<RankingRewardData> RankingRewards;

		public RankingRewardsData(RankingRewardsData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
