using DevLocker.Utils;
using UnityEngine;

namespace CresciveCore
{
	public class SceneLoaderByReference : MonoBehaviour
	{
		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private SceneReference sceneReference;

		public void LoadScene(SceneReference sceneRef)
		{
		}

		public void LoadScene()
		{
		}
	}
}
