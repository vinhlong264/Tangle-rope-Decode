using System;
using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.DataService;
using CresciveCore;
using PersistentSO;
using UnityEngine;

[CreateAssetMenu(menuName = "Crescive/Levels Data Service/DataService/LevelsDataService", order = 0, fileName = "LevelsDataService")]
public class LevelsDataDataService : DataReadService<LevelsSettings>
{
	[SerializeField]
	private LevelsDatabase levelDataBase;

	private readonly Dictionary<int, LevelCreatorData> _levelLookup;

	private readonly List<LevelCreatorData> _orderedLevelCreatorData;

	private readonly List<string> _levelDifficultPatterns;

	private readonly List<int> _loopLevelsList;

	private readonly List<FillerLevelData> _fillerLevelsList;

	private bool _isUsingLoopLevelAtNewLevels;

	[SerializeField]
	private PersistentIntVariable playerLevelVersion;

	[SerializeField]
	private PersistentIntVariable loopBreakPoint;

	[SerializeField]
	private PersistentStringListVariable pendingNewLevels;

	[SerializeField]
	private PersistentStringVariable cachedLoopeLevel;

	[SerializeField]
	private LevelSystem levelSystem;

	private bool _isOrderSet;

	private bool _isLoopLevelsSet;

	public LevelCreatorData CurrentLevelData { get; set; }

	public static bool NewLevelDataFixed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override LevelsSettings GetInitialDataCopy()
	{
		return null;
	}

	protected override bool IsDataValid(LevelsSettings plainData)
	{
		return false;
	}

	public LevelsSettings GetConfig(string offerId)
	{
		return null;
	}

	private bool IsRecyclingLevelsOnLoop(int level)
	{
		return false;
	}

	public void SyncOnAppStart(Action unknown)
	{
	}

	private void BuildLookup()
	{
	}

	private void ExpandLevelsWithFlag()
	{
	}

	private void ExpandFlaggedList(List<int> list)
	{
	}

	private void SetLoopLevels()
	{
	}

	private void SetLevelsOrder()
	{
	}

	private void SetFillerLevels()
	{
	}

	public LevelCreatorData GetLevelDataByLevelID(int id)
	{
		return null;
	}

	public LevelCreatorData GetLevelData(int levelNumber, bool isCurrentLevel)
	{
		return null;
	}

	private bool TryGetLevel(int levelId, out LevelCreatorData data)
	{
		data = null;
		return false;
	}

	private LevelCreatorData TryGetLevel(int levelId, bool isOnLoop)
	{
		return null;
	}

	private void ApplyLevelDataOverrides(LevelCreatorData data, LevelOverrideData overrideData, LevelWithTime levelWithTime)
	{
	}

	private bool TryGetNewLevel(int level, out LevelCreatorData levelData, bool isCurrentLevel)
	{
		levelData = null;
		return false;
	}

	private LevelCreatorData GetLoopLevel(int levelNumber)
	{
		return null;
	}

	private LevelCreatorData GetLevelCreatorDataWithOrder(int levelNumber, bool isCurrentLevel)
	{
		return null;
	}

	private void CheckNewLevels()
	{
	}

	private void SetPlayerVersion()
	{
	}

	private void SetLoopBreakPoint()
	{
	}

	private void AdjustPendingNewLevels()
	{
	}

	private LevelCreatorData GetRandomLevel(int index)
	{
		return null;
	}

	public string GetDifficulty(int levelNumber)
	{
		return null;
	}

	public void SetCachedLevel(string levelName)
	{
	}

	public string GetCachedLevelName()
	{
		return null;
	}

	public int GetCachedLevelID()
	{
		return 0;
	}

	public void TryRemoveFirstNewLevels()
	{
	}

	private int FindLevelOrderById(int levelId)
	{
		return 0;
	}
}
