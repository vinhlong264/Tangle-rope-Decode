using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore
{
	public abstract class BaseLevelsData<T> : ScriptableObject
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<BaseLevelsDataProcessor<T>> processors;

		[SerializeField]
		private List<T> levels;

		[SerializeField]
		private List<T> exceptedLevelsOnLoop;

		public int CurrentLevelNumber => 0;

		public int CurrentActualLevelIndex => 0;

		public int CurrentActualLevelNumber => 0;

		public T CurrentLevelData => default(T);

		public List<T> Levels => null;

		public List<T> ExceptedLevelsOnLoop => null;

		private List<T> GetProcessedLevels()
		{
			return null;
		}

		private List<T> GetProcessedExceptedLevelsOnLoop()
		{
			return null;
		}

		private List<T> GetProcessedAvailableLevels(int levelNumber)
		{
			return null;
		}

		private int CalculateLevelIndex(int levelNumber)
		{
			return 0;
		}

		private bool IsRecyclingLevelsOnLoop(List<T> levelList, int levelNumber)
		{
			return false;
		}

		public T GetCurrentLevelData()
		{
			return default(T);
		}

		public T GetLevelData(int levelNumber)
		{
			return default(T);
		}

		public void CopyOriginalJsonDataToClipboard()
		{
		}
	}
}
