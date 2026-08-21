using System;

namespace Crescive.League
{
	[Serializable]
	public class LiveLeagueSaveData : ICloneable
	{
		public LiveLeagueSettings Settings;

		public bool IsActive;

		public bool IsEntered;

		public string EnterDate;

		public int CurrentRoundNumber;

		public int TotalCompletedRoundCount;

		public LiveLeagueSaveData(LiveLeagueSaveData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
