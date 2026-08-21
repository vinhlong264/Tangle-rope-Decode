using Crescive.CreatorMode;
using CresciveCore;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LevelCreatorDataSetupAtAwake : BaseCreatorLevelDataSetupAtAwake<LevelCreatorData, LevelCreatorSaveData>
	{
		[SerializeField]
		private LevelCreatorAtStart levelCreatorAtStart;

		protected override LevelCreatorData CreatorData => null;

		protected override BaseLevelCreatorAtStart<LevelCreatorData, LevelCreatorSaveData> LevelCreatorAtStart => null;
	}
}
