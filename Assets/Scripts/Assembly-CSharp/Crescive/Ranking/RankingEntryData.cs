using System;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingEntryData : ICloneable
	{
		public int id;

		public string playerName;

		public float score;

		public string countryCode;

		public RankingEntryData(int id, string playerName, float score, string countryCode)
		{
		}

		public RankingEntryData(RankingEntryData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
