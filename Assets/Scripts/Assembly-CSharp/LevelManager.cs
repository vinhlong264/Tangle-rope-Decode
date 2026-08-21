using Crescive.CreatorMode;
using Crescive.Levels;
using CresciveCore;
using MyBox;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : Singleton<LevelManager>
{
	[SerializeField]
	private LevelsDataDataService levelsDataService;

	[SerializeField]
	private LevelSystem levelSystem;

	public UnityEvent<NewLevelsData> OnNewLevelsAdded;

	public UnityEvent<NewLevelsData> OnNewLevelsAddedWhenOnLoop;

	public UnityEvent OnUniqueLevelCompleted;

	public UnityEvent OnLoopLevelCompleted;

	public UnityEvent OnUniqueLevelsCompleted;

	private bool _isInitialized;

	public LevelCreatorData CurrentLevelData => null;

	public int PlayingTotalLevelNumber => 0;

	public int GetCurrentLevelID()
	{
		return 0;
	}

	private void Initialize()
	{
	}

	public LevelCreatorData GetLevelDataByLevelID(int id = -1)
	{
		return null;
	}

	public LevelCreatorData GetLevelData(int levelNumber, bool isCurrentLevel = false)
	{
		return null;
	}

	public void OnLevelCompleted()
	{
	}

	public string GetDifficulty(int levelNumber = -1)
	{
		return null;
	}

	public LevelTheme GetLevelTheme()
	{
		return default(LevelTheme);
	}

	public void LevelCreated()
	{
	}
}
