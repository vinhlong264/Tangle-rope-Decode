using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.Levels
{
	public class BasicLevelDataSetup : BaseLevelDataSetup
	{
		[SerializeField]
		private LevelCreatorData levelCreatorData;

		protected override UniTask<LevelCreatorSaveData> GetLevelData()
		{
			return default(UniTask<LevelCreatorSaveData>);
		}
	}
}
