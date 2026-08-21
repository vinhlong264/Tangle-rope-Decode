using System;

namespace Crescive.League
{
	[Serializable]
	public struct LeagueProgressData
	{
		public float TotalProgress;

		public float LocalProgress;

		public float LocalEnterCatchUpPercent;

		public int TotalDaysFromLocalEnter;

		public int TotalDaysFromActualStart;
	}
}
