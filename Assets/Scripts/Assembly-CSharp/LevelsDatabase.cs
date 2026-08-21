using System.Collections.Generic;
using Crescive.CreatorMode;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelsDatabase", menuName = "Crescive/Levels Data Service/DataService/LevelsDatabase")]
public class LevelsDatabase : ScriptableObject
{
	public List<LevelCreatorData> allLevels;

	private const string ResourcePath = "Levels/TextFiles";

	private Dictionary<int, string> levelTexts;

	public List<int> lastAddedLevels;

	public List<int> lastUpdatedLevels;

	public List<LevelCreatorData> shiftLevel;

	public int id;

	public void ReadLevelTexts()
	{
	}

	private void CreateNewLevelAndToAllLevels(int levelKey, string levelValue)
	{
	}

	private void UpdateLevelData(LevelCreatorData find)
	{
	}

	public void Shift()
	{
	}

	public void CopyLevelRopes()
	{
	}

	public void CopyLevelTime()
	{
	}

	public void PasteLevelTimeAndDifficult()
	{
	}
}
