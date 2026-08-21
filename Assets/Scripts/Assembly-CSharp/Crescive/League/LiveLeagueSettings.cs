using System;
using UnityEngine;

namespace Crescive.League
{
	[Serializable]
	public class LiveLeagueSettings : ICloneable
	{
		public int LeagueNumber;

		public string StartDate;

		public string FinishDate;

		public int PlayerCount;

		public int MaxScore;

		public int AvgLevelPerDayToFinish;

		[Range(0f, 1f)]
		public float PlayerRandomScoreIncreaseVariationPercent;

		[Range(0f, 1f)]
		public float FakePlayersMinScoreVariationPercent;

		[Range(0f, 1f)]
		public float FakePlayersMaxScoreVariationPercent;

		public int GetRemainingSeconds()
		{
			return 0;
		}

		public LiveLeagueSettings(LiveLeagueSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
