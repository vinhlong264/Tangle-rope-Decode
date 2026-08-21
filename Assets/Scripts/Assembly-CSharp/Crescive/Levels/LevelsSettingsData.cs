using System;
using System.Collections.Generic;
using System.Linq;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelsSettingsData
	{
		public List<LevelSettingsData> LevelsSettings;

		public List<DifficultySettingsData> DifficultySettings;

		public LevelsSettingsData(LevelsSettingsData other)
		{
			if (other == null)
			{
				LevelsSettings = new List<LevelSettingsData>();
				DifficultySettings = new List<DifficultySettingsData>();
				return;
			}

			LevelsSettings = other.LevelsSettings?.Select((LevelSettingsData item) => (item != null) ? new LevelSettingsData(item) : null).ToList() ?? new List<LevelSettingsData>();
			DifficultySettings = other.DifficultySettings?.Select((DifficultySettingsData item) => (item != null) ? new DifficultySettingsData(item) : null).ToList() ?? new List<DifficultySettingsData>();
		}

		public object Clone()
		{
			return new LevelsSettingsData(this);
		}

		public LevelSettingsData GetLevelSettingsData(int levelNumber)
		{
			return LevelsSettings?.Find((LevelSettingsData item) => item != null && item.Number == levelNumber);
		}

		public DifficultySettingsData GetDifficultySettingsData(string difficulty)
		{
			return DifficultySettings?.Find((DifficultySettingsData item) => item != null && string.Equals(item.Difficulty, difficulty, StringComparison.OrdinalIgnoreCase));
		}
	}
}
