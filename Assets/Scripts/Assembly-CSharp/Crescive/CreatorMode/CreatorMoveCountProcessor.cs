using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "CreatorMoveCountProcessor", menuName = "Crescive/Creator Mode/Processor/CreatorMoveCountProcessor")]
	public class CreatorMoveCountProcessor : BaseCreatorSaveDataProcessor<LevelCreatorSaveData>
	{
		[SerializeField]
		private IntVariableReference moveCount;

		public override LevelCreatorSaveData ProcessSaveData(LevelCreatorSaveData saveData)
		{
			return null;
		}
	}
}
