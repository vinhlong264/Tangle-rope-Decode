using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LevelCreatorAtStart : BaseLevelCreatorAtStart<LevelCreatorData, LevelCreatorSaveData>
	{
		[SerializeField]
		private LevelCreatorChannel levelCreator;

		protected override BaseLevelCreator<LevelCreatorData, LevelCreatorSaveData> Creator => null;
	}
}
