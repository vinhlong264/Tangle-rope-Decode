using System;

namespace Crescive.Rewards
{
	[Serializable]
	public struct DailyRewardStateData
	{
		public int collectedDaysCount;

		public string lastCollectedDate;

		public DailyRewardStateData(int collectedDaysCount, string lastCollectedDate)
		{
			this.collectedDaysCount = 0;
			this.lastCollectedDate = null;
		}

		public DailyRewardStateData(DailyRewardStateData value)
		{
			collectedDaysCount = 0;
			lastCollectedDate = null;
		}
	}
}
