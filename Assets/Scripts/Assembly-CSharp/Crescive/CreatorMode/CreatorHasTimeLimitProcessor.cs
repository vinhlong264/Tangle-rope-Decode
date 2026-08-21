using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "CreatorSaveDataTimeLimitProcessor", menuName = "Crescive/Creator Mode/Processor/CreatorSaveDataTimeLimitProcessor")]
	public class CreatorHasTimeLimitProcessor : BaseCreatorSaveDataProcessor<LevelCreatorSaveData>
	{
		[SerializeField]
		private BoolVariableReference hasTimeLimit;

		public override LevelCreatorSaveData ProcessSaveData(LevelCreatorSaveData saveData)
		{
			return null;
		}
	}
}
