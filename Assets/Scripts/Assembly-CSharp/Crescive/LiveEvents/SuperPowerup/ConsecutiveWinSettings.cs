using System;

namespace Crescive.LiveEvents.SuperPowerup
{
	[Serializable]
	public class ConsecutiveWinSettings : ICloneable
	{
		public RewardData RewardData;

		public bool IsEnabled;

		public int FirstShowUpLevel;

		public int WinCountToClaimReward;

		public object Clone()
		{
			return null;
		}

		public ConsecutiveWinSettings()
		{
		}

		public ConsecutiveWinSettings(ConsecutiveWinSettings other)
		{
		}
	}
}
