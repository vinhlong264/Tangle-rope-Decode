using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class AverageLevelMoveCountsData
	{
		public List<LevelMoveCountData> levels;

		public AverageLevelMoveCountsData(AverageLevelMoveCountsData data)
		{
		}
	}
}
