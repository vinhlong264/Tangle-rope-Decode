using System;
using System.Collections.Generic;
using Crescive.Ranking;

namespace Crescive.League
{
	[Serializable]
	public class LeagueHistoryData : ICloneable
	{
		public LiveLeagueSaveData LeagueSaveData;

		public List<RankingEntryData> RankingEntries;

		public int PlayerRank;

		public LeagueHistoryData(LiveLeagueSaveData leagueSaveData, List<RankingEntryData> rankingEntries, int playerRank)
		{
		}

		private LeagueHistoryData(LeagueHistoryData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
