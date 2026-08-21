using CresciveCore;
using PersistentSO;
using UnityEngine;

namespace Crescive.Levels.Save
{
	[CreateAssetMenu(fileName = "PersistentVariableLevelSaveManager", menuName = "Crescive/Level System/Persistent Variable Level Save Manager")]
	public class PersistentVariableLevelSaveManager : LevelSaveManager
	{
		private const string LevelNumberKey = "LevelNumber";

		[SerializeField]
		public PersistentIntVariable currentLevelNumber;

		[SerializeField]
		public PersistentIntVariable currentLevelIndex;

		[SerializeField]
		public PersistentIntVariable highestLevelNumber;

		public override void SaveLevel(int levelNumber, int levelIndex)
		{
		}

		public override void SaveLevelNumber(int levelNumber)
		{
		}

		public override int GetLevelNumber()
		{
			return 0;
		}

		public override void SaveLevelIndex(int index)
		{
		}

		public override int GetLevelIndex()
		{
			return 0;
		}

		public override void SaveHighestLevelNumber(int levelNumber)
		{
		}

		public override int GetHighestLevelNumber()
		{
			return 0;
		}
	}
}
