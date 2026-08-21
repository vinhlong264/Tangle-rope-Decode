using System;

namespace Crescive.RaceSystem
{
	public static class RaceDataExtensions
	{
		public static float GetCurrentRaceTimePercent(this RaceData raceData, RaceSettingsData settings)
		{
			return 0f;
		}

		public static TimeSpan GetCurrentRaceTimeRemaining(this RaceData raceData, RaceSettingsData settings)
		{
			return default(TimeSpan);
		}

		public static float GetCurrentRaceTimeRemainingMinutes(this RaceData raceData, RaceSettingsData settings)
		{
			return 0f;
		}

		public static float GetCurrentRaceTimeRemainingSeconds(this RaceData raceData, RaceSettingsData settings)
		{
			return 0f;
		}

		public static bool ShouldResetRaceCountToday(this RaceData raceData)
		{
			return false;
		}

		public static bool DidStartRace(this RaceData raceData)
		{
			return false;
		}

		public static bool DidFinishRace(this RaceData raceData)
		{
			return false;
		}

		public static bool DidDeclineRace(this RaceData raceData)
		{
			return false;
		}
	}
}
