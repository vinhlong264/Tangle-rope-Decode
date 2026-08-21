using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "CreatorHasMoveCountProcessor", menuName = "Crescive/Creator Mode/Processor/CreatorHasMoveCountProcessor")]
	public class CreatorHasMoveCountProcessor : BaseCreatorSaveDataProcessor<LevelCreatorSaveData>
	{
		[SerializeField]
		private BoolVariableReference hasMoveCount;

		public override LevelCreatorSaveData ProcessSaveData(LevelCreatorSaveData saveData)
		{
			return null;
		}
	}
}
