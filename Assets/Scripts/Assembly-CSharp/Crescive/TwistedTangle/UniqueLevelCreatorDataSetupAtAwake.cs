using Crescive.CreatorMode;
using Crescive.HelperTypes;
using CresciveCore;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class UniqueLevelCreatorDataSetupAtAwake : BaseCreatorLevelDataSetupAtAwake<LevelCreatorData, LevelCreatorSaveData>
	{
		[SerializeField]
		private LevelCreatorAtStart levelCreatorAtStart;

		[SerializeField]
		private IntVariableReference uniqueLevelNumber;

		protected override LevelCreatorData CreatorData => null;

		protected override BaseLevelCreatorAtStart<LevelCreatorData, LevelCreatorSaveData> LevelCreatorAtStart => null;
	}
}
