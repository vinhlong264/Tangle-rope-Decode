using Crescive.CreatorMode;
using UnityEngine;

namespace CresciveCore
{
	public abstract class BaseCreatorLevelDataSetupAtAwake<TCreatorData, TSaveData> : MonoBehaviour where TCreatorData : BaseLevelCreatorData<TSaveData> where TSaveData : BaseCreatorSaveData
	{
		protected abstract TCreatorData CreatorData { get; }

		protected abstract BaseLevelCreatorAtStart<TCreatorData, TSaveData> LevelCreatorAtStart { get; }

		private void Awake()
		{
		}
	}
}
