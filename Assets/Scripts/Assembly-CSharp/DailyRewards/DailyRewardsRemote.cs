using System;
using System.Collections.Generic;

namespace DailyRewards
{
	[Serializable]
	public class DailyRewardsRemote
	{
		public bool isEnabled;

		public int MinLevel;

		public List<RewardList> MonthlyDayTargetRewards;

		public List<RewardList> WeeklyDayRewards;
	}
}
