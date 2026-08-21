using System;
using Crescive.CreatorMode;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Levels/DataService/Levels Settings Service", fileName = "LevelsSettingsService")]
	public class LevelsSettingsService : ScriptableObject
	{
		[SerializeField]
		private LevelsSettingsData initialData;

		[SerializeField]
		private LevelsSettingsData actualData;

		public LevelsSettingsData InitialData => initialData;

		public LevelsSettingsData Data => actualData ?? initialData;

		private void OnEnable()
		{
			if (actualData == null && initialData != null)
			{
				actualData = new LevelsSettingsData(initialData);
			}
		}

		public void SetData(LevelsSettingsData data)
		{
			actualData = ((data != null) ? new LevelsSettingsData(data) : null);
		}

		public LevelSettingsData GetLevelSettings(int levelNumber)
		{
			return Data?.GetLevelSettingsData(levelNumber);
		}

		public DifficultySettingsData GetDifficultySettings(string difficulty)
		{
			return Data?.GetDifficultySettingsData(difficulty);
		}

		public int GetLevelRevisionNumber(int uniqueLevelNumber)
		{
			LevelSettingsData levelSettings = GetLevelSettings(uniqueLevelNumber);
			return (levelSettings != null) ? levelSettings.RevisionNumber : 0;
		}

		public int GetCurrentLevelRevisionNumber()
		{
			return 0;
		}

		public bool HasLevelMoveCountOrTime(int uniqueLevelNumber)
		{
			LevelSettingsData levelSettings = GetLevelSettings(uniqueLevelNumber);
			return levelSettings != null && (levelSettings.HasMoveCount || levelSettings.HasTimeLimit);
		}

		public bool HasCurrentLevelMoveCountOrTime()
		{
			return false;
		}

		public void AddLevelSettings(LevelFunnelData funnel)
		{
		}

		public void Test(int i)
		{
		}

		public void AddTimeToLevels(int time, LevelFunnelData funnelData, StringConstant difficulty, int minLevelNumber = 1)
		{
		}

		public void CopyMoveCountsFromLevelsToClipboard()
		{
		}

		public void CopyTimesFromLevelsToClipboard()
		{
		}

		public void CopyDataFromFunnelToInitial(LevelFunnelData funnel, bool increaseRevision = false)
		{
		}

		public void CopyDataFromInitialToFunnel(LevelFunnelData funnel)
		{
		}

		public void CopyInitialDataJsonToClipboard(bool prettyPrint = true)
		{
			if (initialData != null)
			{
				GUIUtility.systemCopyBuffer = JsonUtility.ToJson(initialData, prettyPrint);
			}
		}

		public void PasteInitialDataJsonFromClipboard()
		{
			if (!string.IsNullOrWhiteSpace(GUIUtility.systemCopyBuffer))
			{
				LevelsSettingsData levelsSettingsData = JsonUtility.FromJson<LevelsSettingsData>(GUIUtility.systemCopyBuffer);
				if (levelsSettingsData != null)
				{
					initialData = levelsSettingsData;
				}
			}
		}

		public void CopyTimesFromClipboardToInitial()
		{
		}

		public void CopyMoveCountsFromClipboardToInitial()
		{
		}

		public void AddMoveCountsFromClipboardToInitial()
		{
		}

		public void AddTimesFromClipboardToInitial()
		{
		}

		public void SetTimesFromClipboardToInitial()
		{
		}

		public void SetTimesFromClipboardToInitialWithMatchingIndexes(int startNumber = 1, bool increaseRevision = false)
		{
		}

		public void SetMoveCountsFromClipboardToInitial()
		{
		}

		public void ResetActualData()
		{
			actualData = ((initialData != null) ? new LevelsSettingsData(initialData) : null);
		}

		public void ValidateInitialDataWithElephant()
		{
		}

		public void IncreaseRevisionNumbersFromClipboard()
		{
		}

		public void IncreaseRevisionNumbersFromLevelNumbersClipboard()
		{
		}

		public void SetAllMoveCounts(int moveCount)
		{
		}

		public void SetRevisionNumbers(int startLevelNumber, int endLevelNumber, int revisionNumber)
		{
		}
	}
}
