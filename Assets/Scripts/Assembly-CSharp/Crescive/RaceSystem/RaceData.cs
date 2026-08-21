using System;

namespace Crescive.RaceSystem
{
	[Serializable]
	public class RaceData
	{
		public string RaceStartTime;

		public string RaceFinishTime;

		public int RaceDeclineLevelNumber;

		public int RaceCountToday;

		public string RaceCountUpdateTime;

		public RaceData(string raceStartTime, string raceFinishTime, int raceDeclineLevelNumber, int raceCountToday, string raceCountUpdateTime)
		{
		}

		public RaceData(RaceData other)
		{
		}
	}
}
