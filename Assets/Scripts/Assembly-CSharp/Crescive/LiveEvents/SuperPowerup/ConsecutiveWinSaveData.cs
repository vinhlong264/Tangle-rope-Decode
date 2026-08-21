using System;

namespace Crescive.LiveEvents.SuperPowerup
{
	[Serializable]
	public class ConsecutiveWinSaveData
	{
		public int WinCount;

		public bool IsRewardClaimed;

		public bool IsTutorialActive;

		public bool IsWinCountChanged;

		public ConsecutiveWinSaveData()
		{
		}

		public ConsecutiveWinSaveData(ConsecutiveWinSaveData? other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
