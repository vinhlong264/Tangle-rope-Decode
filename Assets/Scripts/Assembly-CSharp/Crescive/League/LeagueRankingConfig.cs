using System;
using System.Collections.Generic;
using Crescive.Ranking;
using Easings;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "LeagueRankingConfig", menuName = "Crescive/League/LeagueRankingConfig", order = 0)]
	public class LeagueRankingConfig : ScriptableObject
	{
		[SerializeField]
		private LiveLeagueDataService leagueService;

		[SerializeField]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private FakeRankUserList fakeRankUserList;

		[SerializeField]
		private List<Easing> rankEasings;

		private int MaxScoreBasedOnLeagueEnter => 0;

		private int GetFakePlayerMinScoreUsingEase(int id)
		{
			return 0;
		}

		private int GetFakePlayerMaxScoreUsingEase(int id)
		{
			return 0;
		}

		private int GetPlayerRndomIncreaseScoreVariation(float increaseScore)
		{
			return 0;
		}

		public int GetRandomPlayerIncreaseScore()
		{
			return 0;
		}

		public List<FakeRankUser> GetRandomFakeUsers(int count)
		{
			return null;
		}

		public string GetFakeUserCountryCode(FakeRankUser user)
		{
			return null;
		}

		public int GetFakeUserScore(int id)
		{
			return 0;
		}

		public int GetFakeUserScoreByDate(int id, DateTime date)
		{
			return 0;
		}

		public List<RankingEntryData> GetRankingEntriesWithUpdatedDateScoreSorted(DateTime date)
		{
			return null;
		}

		public List<RankingEntryData> GetRankingEntriesWithCurrentDateScore()
		{
			return null;
		}

		public int GetPlayerRankByDate(DateTime date)
		{
			return 0;
		}

		public int GetPlayerRankByDate(string date)
		{
			return 0;
		}
	}
}
