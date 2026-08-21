using Crescive.Scriptables;
using DevLocker.Utils;
using PersistentSO;
using UnityEngine;

namespace CresciveCore.Utils
{
	public class SpecialLevelLoader : MonoBehaviour
	{
		[SerializeField]
		private PersistentIntVariable specialLevelNumber;

		[SerializeField]
		private bool useSceneLoader;

		[SerializeField]
		private ScriptableAction loadAction;

		[SerializeField]
		private SceneLoaderByReference sceneLoader;

		[SerializeField]
		private LoaderChannel loaderChannel;

		public void LoadSceneWithNumber(int number)
		{
		}

		public void LoadSceneWithNumberAndCustomData(SceneReference customScene, ScriptableAction customLoadAction, int levelNumber)
		{
		}
	}
}
