using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(fileName = "CreatorLevelSettingsProcessor", menuName = "Crescive/Levels/Settings/CreatorLevelSettingsProcessor")]
	public class CreatorLevelSettingsProcessor : BaseCreatorSaveDataProcessor<LevelCreatorSaveData>
	{
		[SerializeField]
		private LevelsSettingsService levelsSettingsService;

		public override LevelCreatorSaveData ProcessSaveData(LevelCreatorSaveData saveData)
		{
			return null;
		}
	}
}
