using System;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingEntryProfileData : ICloneable
	{
		public int rankingEntryId;

		public int iconId;

		public int iconColorId;

		public RankingEntryProfileData(int rankingEntryId, int iconId, int iconColorId)
		{
		}

		public RankingEntryProfileData(RankingEntryProfileData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
