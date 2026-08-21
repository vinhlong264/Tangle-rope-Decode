using System;
using System.Collections.Generic;

namespace Crescive.RaceSystem
{
	[Serializable]
	public class RaceSettingsData
	{
		public int Duration;

		public int WinCondition;

		public int OpponentCount;

		public int MaxRacesPerDay;

		public int FirstOfferLevel;

		public int DeclinedNewOfferInterval;

		public List<float> CoinRewards;

		public RaceSettingsData(int duration, int winCondition, int opponentCount, int maxRacesPerDay, int firstOfferLevel, int declinedNewOfferInterval, List<float> coinRewards)
		{
		}

		public RaceSettingsData(RaceSettingsData other)
		{
		}
	}
}
