using System;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingRewardResourceData : ICloneable
	{
		public string ResourceId;

		public float Amount;

		public RankingRewardResourceData(RankingRewardResourceData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
