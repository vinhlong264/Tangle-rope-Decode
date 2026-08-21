using System;

namespace DailyRewards
{
	[Serializable]
	public class DailyRewardsData
	{
		public string FirstInitDate;

		public string LastLoginDate;

		public DateTime FirstDate;

		public DateTime LastDate;

		public bool[] IsClaimedWeeklyArray;

		public bool[] IsClaimedMonthlyArray;

		public int MonthDayProgression;

		public bool IsFirstTime;

		public int loopDelayCount;
	}
}
