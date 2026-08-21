using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelListData : ICloneable
	{
		public List<int> Levels;

		public LevelListData()
		{
		}

		public LevelListData(List<int> levels)
		{
		}

		public LevelListData(LevelListData levelListData)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
