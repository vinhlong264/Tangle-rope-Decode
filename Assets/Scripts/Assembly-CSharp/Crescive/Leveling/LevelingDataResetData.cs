using System;

namespace Crescive.Leveling
{
	[Serializable]
	public struct LevelingDataResetData
	{
		public LevelingData LevelingData;

		public int ResetValue;

		public LevelingDataResetData(LevelingData levelingData)
		{
			LevelingData = null;
			ResetValue = 0;
		}
	}
}
