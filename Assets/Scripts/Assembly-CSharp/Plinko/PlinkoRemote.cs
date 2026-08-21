using System;
using System.Collections.Generic;

namespace Plinko
{
	[Serializable]
	public class PlinkoRemote
	{
		public int MinLevel;

		public int StartDayOfWeek;

		public int EndDayOfWeek;

		public int StartTokenCount;

		public int LevelWinTokenCount;

		public int HardLevelWinTokenCount;

		public int VeryHardLevelWinTokenCount;

		public int[] Multipliers;

		public int[] RewardCounts;

		public int[] RefreshCurrencyCounts;

		public List<ProbabilityRewardRemote> probablityRewardRemotes;

		public bool IsEnabled => false;
	}
}
