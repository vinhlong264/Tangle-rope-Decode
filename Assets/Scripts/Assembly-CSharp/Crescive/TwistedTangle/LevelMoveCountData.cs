using System;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class LevelMoveCountData
	{
		public int Level;

		public int MoveCount;

		public LevelMoveCountData(int level, int moveCount)
		{
		}

		public LevelMoveCountData(LevelMoveCountData data)
		{
		}
	}
}
