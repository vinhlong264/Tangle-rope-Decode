using System;

namespace Stats
{
	[Serializable]
	public class StatDatas
	{
		public int WinCount;

		public int LoseCount;

		public int ConsecutiveDailyLogin;

		public int FirstTryWin;

		public int MaxLevelWinPerDay;

		public int LastFailedLevel;

		public DateTime CurrentFirstLoginDate;

		public DateTime LastThisDataSavedDate;

		public int CurrentMaxLevelWin;

		public StatDatas()
		{
		}

		public StatDatas(StatDatas statDatas)
		{
		}
	}
}
