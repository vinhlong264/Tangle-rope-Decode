using UnityEngine;

namespace Crescive.Utils
{
	[DefaultExecutionOrder(int.MinValue)]
	public class GameObjectLoader : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] gameObjects;

		[SerializeField]
		private Transform parent;

		[Space]
		[SerializeField]
		private bool loadOnAwake;

		[SerializeField]
		private bool worldPositionStays;

		private void Awake()
		{
		}

		public void LoadGameObjects()
		{
		}
	}
}
