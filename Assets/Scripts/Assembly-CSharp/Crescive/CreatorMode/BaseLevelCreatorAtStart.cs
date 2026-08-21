using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public abstract class BaseLevelCreatorAtStart<TCreatorData, TSaveData> : MonoBehaviour where TCreatorData : BaseLevelCreatorData<TSaveData> where TSaveData : BaseCreatorSaveData
	{
		[SerializeField]
		private TCreatorData creatorData;

		public UnityEvent<TCreatorData> OnLevelCreated;

		protected abstract BaseLevelCreator<TCreatorData, TSaveData> Creator { get; }

		private void Start()
		{
		}

		public void SetCreatorData(TCreatorData data)
		{
		}
	}
}
