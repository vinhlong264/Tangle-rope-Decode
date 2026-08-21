using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelsDifficultyMap
	{
		public List<DifficultyLevels> LevelsByDifficulty;

		public LevelsDifficultyMap(List<int> levelNumbers, Func<int, string> levelToDifficulty)
		{
		}

		public LevelsDifficultyMap(List<DifficultyLevels> levelsByDifficulty)
		{
		}

		public LevelsDifficultyMap(LevelsDifficultyMap other)
		{
		}

		private bool HasDifficultyPattern(List<DifficultyLevels> copyLevelsByDifficulty, List<string> diffPattern)
		{
			return false;
		}

		public void ShuffleAllLevels(int seed)
		{
		}

		public void ShuffleAllLevels()
		{
		}

		public List<int> GetLevelsFromPatternOrder(List<string> diffPattern)
		{
			return null;
		}

		public DifficultyLevels GetDifficultyLevels(List<DifficultyLevels> levelsByDifficulty, string difficulty)
		{
			return null;
		}

		public DifficultyLevels GetDifficultyLevels(string difficulty)
		{
			return null;
		}
	}
}
