using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class DifficultySettingsData
	{
		public string Difficulty;

		public int MoveCountOffset;

		public int TimeLimitOffset;

		private List<string> Difficulties => new List<string> { "Easy", "Medium", "Hard", "Very Hard" };

		public DifficultySettingsData(DifficultySettingsData other)
		{
			if (other == null)
			{
				return;
			}

			Difficulty = other.Difficulty;
			MoveCountOffset = other.MoveCountOffset;
			TimeLimitOffset = other.TimeLimitOffset;
		}

		public object Clone()
		{
			return new DifficultySettingsData(this);
		}
	}
}
