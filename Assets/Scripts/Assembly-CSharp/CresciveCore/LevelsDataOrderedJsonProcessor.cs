using System.Collections.Generic;
using Crescive.CreatorMode;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace CresciveCore
{
	[CreateAssetMenu(fileName = "LevelsDataJsonProcessor", menuName = "GameData/LevelsData/Processors/LevelsDataJsonProcessor", order = 0)]
	public class LevelsDataOrderedJsonProcessor : BaseLevelsDataProcessor<LevelCreatorData>
	{
		[SerializeField]
		private StringVariable orderedLevelsJson;

		public override List<LevelCreatorData> ProcessLevelsData(List<LevelCreatorData> levels)
		{
			return null;
		}

		public override List<LevelCreatorData> ProcessExceptedLevelsOnLoop(List<LevelCreatorData> levels)
		{
			return null;
		}
	}
}
