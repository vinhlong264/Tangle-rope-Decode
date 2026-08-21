using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore
{
	[CreateAssetMenu(fileName = "LoaderChannel", menuName = "Loader/Channels/LoaderChannel")]
	public class LoaderChannel : ScriptableObject
	{
		[SerializeField]
		private Loader loader;

		public UnityEvent OnLoadingRequested => null;

		public UnityEvent OnLoadingStarted => null;

		public UnityEvent OnLoadingFinished => null;

		public UnityEvent OnLoadingOtherSceneStarted => null;

		public UnityEvent OnLoadingOtherSceneFinished => null;

		public UnityEvent OnLoadingHomeStarted => null;

		public UnityEvent OnLoadingHomeFinished => null;

		public UnityEvent OnLoadLastLeveRequested => null;

		public bool IsLoaderInitialized => false;

		public void LoadNextLevel(bool delayed)
		{
		}

		public void LoadPreviousLevel(bool delayed)
		{
		}

		public void LoadLevel(int levelNumber, bool delayed)
		{
		}

		public void LoadLevelWithId(int levelId, bool delayed)
		{
		}

		public void LoadLevelImmediate(int levelNumber)
		{
		}

		public void LoadLevelDelayed(int levelNumber)
		{
		}

		public void LoadHome(bool delayed)
		{
		}

		public void LoadScene(string sceneName)
		{
		}

		public void LoadExtraScene(int extraSceneIndex)
		{
		}

		public void LoadLastSavedLevel(bool delayed)
		{
		}

		public void RestartLevel(bool delayed)
		{
		}

		public void SetLoader(Loader loader)
		{
		}

		public bool CheckIfHomeMenuActive()
		{
			return false;
		}
	}
}
