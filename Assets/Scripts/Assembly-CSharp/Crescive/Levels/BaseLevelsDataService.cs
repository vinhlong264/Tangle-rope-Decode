using System;
using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.DataService;
using Crescive.HelperTypes;
using CresciveCore;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Levels
{
	public abstract class BaseLevelsDataService<T> : DataReadService<LevelsData> where T : LevelCreatorData
	{
		[Serializable]
		public class RandomLevelPool
		{
			public string levelDifficultyPattern;

			public List<T> levels;

			private List<string> Difficulties => null;
		}

		[SerializeField]
		private List<BaseLevelFunnelData<T>> funnels;

		[SerializeField]
		private IntVariableReference funnelNumber;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private PersistentIntVariable lastAddedMinLevelNumberOrdered;

		[SerializeField]
		private PersistentIntVariable lastAddedMaxLevelNumberOrdered;

		[SerializeField]
		private PersistentIntVariable maxCompletedLevelNumberOrdered;

		[SerializeField]
		private PersistentIntVariable currentLevelNumberOrdered;

		[SerializeField]
		private PersistentIntListVariable loopLevels;

		[SerializeField]
		private PersistentIntVariable totalLoopLevelNumber;

		[SerializeField]
		private PersistentBoolVariable playingNewLevelsOnLoop;

		[SerializeField]
		private IntVariableReference loopLevelsShuffleSeed;

		[SerializeField]
		private BoolVariableReference forceLinearLevelsOnLoop;

		[SerializeField]
		private BasicLevelsService onboardLoopLevelsService;

		[SerializeField]
		private PersistentIntListVariable lastOnboardLoopLevels;

		[SerializeField]
		private PersistentIntVariable lastUsedOnboardLoopLevelsNumber;

		[SerializeField]
		private IntVariableReference currentOnboardLoopLevelsNumber;

		[SerializeField]
		private BoolVariableReference useOnboardLoopLevels;

		private int lastStartedLevelNumberOrdered;

		private bool _isUsingNewLevelsOnLoop;

		private bool _useLoopLevelForFiller;

		public UnityEvent<NewLevelsData> OnNewLevelsAdded;

		public UnityEvent<NewLevelsData> OnNewLevelsAddedWhenOnLoop;

		public UnityEvent OnUniqueLevelCompleted;

		public UnityEvent OnLoopLevelCompleted;

		public UnityEvent OnUniqueLevelsCompleted;

		[SerializeField]
		private PersistentIntVariable playerLevelVersion;

		[SerializeField]
		private PersistentIntVariable loopBreakPoint;

		[SerializeField]
		private PersistentStringVariable cachedLoopeLevel;

		[SerializeField]
		private PersistentStringListVariable pendingNewLevels;

		[SerializeField]
		private List<RandomLevelPool> randomLevelPools;

		private int FunnelIndex => 0;

		private BaseLevelFunnelData<T> CurrentFunnel => null;

		private bool UseShuffledLevelsOnLoop => false;

		public List<T> Levels => null;

		public T CurrentLevelData => null;

		public string CurrentLevelDifficulty => null;

		public int PlayingTotalLevelNumber => 0;

		public int PlayingLevelIndex => 0;

		public int PlayingLevelNumberUnique => 0;

		public int PlayingLevelNumberOrdered => 0;

		public bool IsPlayingUniqueLevel => false;

		public bool IsPlayingLoopLevel => false;

		public bool IsUsingLoopLevels => false;

		public bool IsAllUniqueLevelsCompleted => false;

		public int LastAddedMinLevelNumberUnique => 0;

		public int LastAddedMaxLevelNumberUnique => 0;

		protected override LevelsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LevelsData plainData)
		{
			return false;
		}

		private T GetCurrentLevelData()
		{
			return null;
		}

		private bool IsRecyclingLevelsOnLoop(int levelNumber)
		{
			return false;
		}

		private List<T> GetOrderedLevels()
		{
			return null;
		}

		private List<T> GetOrderedAvailableLevels(int levelNumber)
		{
			return null;
		}

		private List<T> GetExceptedLevelsOnLoop()
		{
			return null;
		}

		private int CalculateLevelIndex(int levelNumber)
		{
			return 0;
		}

		private void TrySetupOnboardingLoopLevels()
		{
		}

		private void TrySetupLoopLevels()
		{
		}

		private T GetCurrentLoopLevel()
		{
			return null;
		}

		private int GetLevelIndex(T level)
		{
			return 0;
		}

		private int GetLevelNumberUnique(T level)
		{
			return 0;
		}

		private int GetLevelNumberOrdered(T level)
		{
			return 0;
		}

		private int GetLevelNumberOrderedByUniqueNumber(int uniqueLevelNumber)
		{
			return 0;
		}

		private int GetLevelNumberUniqueByOrderedNumber(int orderedNumber)
		{
			return 0;
		}

		private T GetAvailableLevel(int levelNumber)
		{
			return null;
		}

		private T GetLevelByLoop(int index)
		{
			return null;
		}

		private T GetLoopLevel()
		{
			return null;
		}

		private bool TryGetNewLevel(int level, out T levelCreatorData)
		{
			levelCreatorData = null;
			return false;
		}

		private void UpdateUniqueLevelNumbersOnLevelComplete(int maxCompletedNumberOrdered)
		{
		}

		private void SetupUniqueLevelNumbersOnAppStartIfNeeded()
		{
		}

		private NewLevelsData GetNewAddedLevelsData()
		{
			return null;
		}

		private void TryTriggerNewLevelsAddedEvents(NewLevelsData newLevelsData)
		{
		}

		private bool MustAddNewLevelsToLoopImmediate(NewLevelsData newLevelsData)
		{
			return false;
		}

		private void AddNewLevelsToLoopIfNeeded(NewLevelsData newLevelsData)
		{
		}

		private void AddShuffledLoopLevels(List<int> levelNumbers)
		{
		}

		private string GetLevelDifficultyByUniqueNumber(int levelNumber)
		{
			return null;
		}

		private void UpdateLoopLevels()
		{
		}

		private void RemoveInvalidLoopLevels()
		{
		}

		private void SetupLastAddedLevelNumbers(NewLevelsData newLevelsData)
		{
		}

		private List<int> GetLastAddedLevelNumbersOrdered()
		{
			return null;
		}

		private List<int> GetLastAddedLevelNumbersUnique()
		{
			return null;
		}

		private bool HasNewLevelsOnLoop()
		{
			return false;
		}

		private int GetMaxNewLevelIndexInLoop()
		{
			return 0;
		}

		private void TryRemoveFirstLoopLevelOnLevelComplete()
		{
		}

		private void TryRemoveFirstNewLevels()
		{
		}

		private void HandleUniqueOrLoopLevelCompleted()
		{
		}

		public void SyncOnLevelStarted()
		{
		}

		public void SyncOnLevelCompleted()
		{
		}

		public void SyncOnAppStart()
		{
		}

		public T GetLevelDataByUniqueNumber(int uniqueLevelNumber)
		{
			return null;
		}

		public T GetLevelData(int levelNumber)
		{
			return null;
		}

		private void CheckNewLevels()
		{
		}

		private void AdjustPendingNewLevels()
		{
		}

		private T GetRandomLevel(int index)
		{
			return null;
		}

		public string GetDifficulty(int levelNumber)
		{
			return null;
		}

		private bool IsLevelFromNewLevelsOnLoop(int levelNumber)
		{
			return false;
		}

		public void SyncLevelsToOrder()
		{
		}

		public void LogLevelName(int levelNumber = 1)
		{
		}

		public void AddLevels(int count = 1)
		{
		}

		public void AddLevelsFromClipboard()
		{
		}

		public void AddExceptedLoopLevels(int count = 1)
		{
		}

		public void RemoveLevelsFromEnd(int count = 1)
		{
		}

		public void AddLevelsFromNotUsed(int count = 100, int startNumber = 100)
		{
		}
	}
}
