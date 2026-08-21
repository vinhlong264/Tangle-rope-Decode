using System;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class SpesificLevelMoveCountOffset : ICloneable
	{
		public int Level;

		public int Offset;

		public SpesificLevelMoveCountOffset(int level, int offset)
		{
		}

		public SpesificLevelMoveCountOffset(SpesificLevelMoveCountOffset data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
