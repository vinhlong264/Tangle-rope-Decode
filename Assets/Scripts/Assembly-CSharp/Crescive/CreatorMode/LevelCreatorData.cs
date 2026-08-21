using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "Level Creator Data", menuName = "Level Creator/LevelCreatorData", order = 0)]
	public class LevelCreatorData : BaseLevelCreatorData<LevelCreatorSaveData>
	{
		public override LevelCreatorSaveData SaveData => null;

		public LevelCreatorData(LevelCreatorData data)
		{
		}

		public void SetTime(int levelTimeLimit)
		{
		}

		public void SetLevelData(LevelOverrideData overrideDataLevelData)
		{
		}

		public void SetTimeDummy(int timeInSeconds)
		{
		}

		public void SetDifficulty(string levelDifficulty)
		{
		}

		public void SetSaveData(LevelCreatorSaveData dummyData)
		{
		}
	}
}
