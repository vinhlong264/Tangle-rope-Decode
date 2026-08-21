using DevLocker.Utils;
using UnityEngine;

namespace CresciveCore
{
	[CreateAssetMenu(menuName = "Crescive/Loader/LoadSceneAction", fileName = "LoadSceneAction")]
	public class LoadSceneAction : ScriptableObject
	{
		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private SceneReference sceneReference;

		public void Execute()
		{
		}
	}
}
