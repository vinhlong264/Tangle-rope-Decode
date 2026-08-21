using System;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingRewardBoosterData : ICloneable
	{
		public string BoosterId;

		public float Amount;

		public RankingRewardBoosterData(string boosterId, float amount)
		{
		}

		public RankingRewardBoosterData(RankingRewardBoosterData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
