using Crescive.CreatorMode;
using Crescive.HelperTypes;
using Crescive.TwistedTangle;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.Levels
{
	public class UniqueNormalLevelDataSetup : BaseLevelDataSetup
	{
		[SerializeField]
		private IntVariableReference uniqueLevelNumber;

		protected override UniTask<LevelCreatorSaveData> GetLevelData()
		{
			return default(UniTask<LevelCreatorSaveData>);
		}
	}
}
