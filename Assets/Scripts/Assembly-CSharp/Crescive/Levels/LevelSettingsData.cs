using System;
using Crescive.CreatorMode;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelSettingsData 
	{
		public int Number;

		public bool HasMoveCount;

		public int MoveCount;

		public bool HasTimeLimit;

		public int TimeLimit;

		public int RevisionNumber;

		public LevelSettingsData()
		{
		}

		public LevelSettingsData(int number, bool hasMoveCount, int moveCount, bool hasTimeLimit, int timeLimit, int revisionNumber)
		{
			Number = number;
			HasMoveCount = hasMoveCount;
			MoveCount = moveCount;
			HasTimeLimit = hasTimeLimit;
			TimeLimit = timeLimit;
			RevisionNumber = revisionNumber;
		}

		public LevelSettingsData(LevelSettingsData other)
		{
			if (other == null)
			{
				return;
			}

			Number = other.Number;
			HasMoveCount = other.HasMoveCount;
			MoveCount = other.MoveCount;
			HasTimeLimit = other.HasTimeLimit;
			TimeLimit = other.TimeLimit;
			RevisionNumber = other.RevisionNumber;
		}

		public LevelSettingsData(int number)
		{
			Number = number;
		}

		public object Clone()
		{
			return new LevelSettingsData(this);
		}

		public bool IsLevelSettingsDifferent(LevelCreatorSaveData data)
		{
			if (data?.levelData == null)
			{
				return true;
			}

			return HasMoveCount != data.levelData.hasMoveCount || MoveCount != data.levelData.moveCount || HasTimeLimit != data.levelData.hasTimeLimit || TimeLimit != data.levelData.timeLimit;
		}
	}
}
