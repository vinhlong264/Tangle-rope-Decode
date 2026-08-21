using Crescive.DataService;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "LevelsMoveCountSettingsService", menuName = "GameData/Gameplay/MoveCount/Service/LevelsMoveCountSettingsService")]
	public class LevelsMoveCountSettingsService : DataReadService<LevelsMoveCountSettings>
	{
		[SerializeField]
		private AverageLevelMoveCountsService avgMoveCountsService;

		[SerializeField]
		private BoolVariableReference enabledCondition;

		protected override LevelsMoveCountSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LevelsMoveCountSettings plain)
		{
			return false;
		}

		public int GetCurrentLevelMoveCount()
		{
			return 0;
		}

		public bool HasCurrentLevelMoveCount()
		{
			return false;
		}

		private bool IsLevelExcluded(int levelNumber)
		{
			return false;
		}
	}
}
