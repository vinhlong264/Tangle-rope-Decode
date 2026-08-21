using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelsData : ICloneable
	{
		public bool UseShuffledLevelsOnLoop;

		public bool AddNewLevelsToLoopImmediate;

		public bool RandomizationEnabled;

		public List<string> LevelDifficultyPattern;

		public List<int> LevelsOrder;

		public List<int> ExceptedLoopLevels;

		private List<string> Difficulties => null;

		public LevelsData(LevelsData other)
		{
		}

		public bool IsValidLoopLevel(int level)
		{
			return false;
		}

		public bool IsInvalidLoopLevel(int level)
		{
			return false;
		}

		public object Clone()
		{
			return null;
		}
	}
}
