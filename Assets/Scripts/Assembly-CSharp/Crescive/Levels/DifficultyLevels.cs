using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class DifficultyLevels : ICloneable
	{
		public string Difficulty;

		public List<int> Levels;

		public DifficultyLevels(string difficulty, List<int> levels)
		{
		}

		public DifficultyLevels(string difficulty)
		{
		}

		public DifficultyLevels(DifficultyLevels other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void ShuffleLevels(int seed)
		{
		}
	}
}
