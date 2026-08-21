using System;

namespace Crescive.Analytics
{
	[Serializable]
	public struct LevelCompletedEventInterval
	{
		public int StartLevel;

		public int EndLevel;

		public int IncreaseAmount;
	}
}
