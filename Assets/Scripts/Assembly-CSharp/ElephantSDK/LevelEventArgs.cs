using System;

namespace ElephantSDK
{
	[Serializable]
	public class LevelEventArgs
	{
		public int LevelNumber;

		public int LevelId;

		public string LevelIdString => null;

		public LevelEventArgs(int levelNumber, int levelId)
		{
		}
	}
}
