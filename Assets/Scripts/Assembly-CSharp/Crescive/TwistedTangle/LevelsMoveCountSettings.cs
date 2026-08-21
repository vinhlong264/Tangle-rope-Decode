using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class LevelsMoveCountSettings : ICloneable
	{
		public bool OnlyAvailableOnLoop;

		public int OffsetGeneral;

		public int MinMoveCountToUseCustomOffset;

		public int CustomOffsetBelowMin;

		public List<SpesificLevelMoveCountOffset> SpesificLevelsOffsets;

		public List<int> ExcludedLevels;

		public LevelsMoveCountSettings(LevelsMoveCountSettings data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
