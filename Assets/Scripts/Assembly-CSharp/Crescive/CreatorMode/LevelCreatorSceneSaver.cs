using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[DefaultExecutionOrder(100)]
	public class LevelCreatorSceneSaver : MonoBehaviour
	{
		[SerializeField]
		private LevelSaverChannel saverChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private LevelCreatorChannel creatorChannel;

		[SerializeField]
		private PersistentLevelCreatorData persistentData;

		private void Start()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void LoadLastSave()
		{
		}

		public void Save()
		{
		}
	}
}
