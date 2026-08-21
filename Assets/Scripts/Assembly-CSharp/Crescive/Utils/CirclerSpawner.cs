using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	public class CirclerSpawner : MonoBehaviour
	{
		[SerializeField]
		private IntReference count;

		[SerializeField]
		private GameObject prefab;

		[SerializeField]
		private Transform parent;

		[SerializeField]
		private bool autoSpawnAtStart;

		[SerializeField]
		private Vector3 axis;

		private void Start()
		{
		}

		public void Spawn()
		{
		}

		public void UpdateCountAndSpawn(int count)
		{
		}
	}
}
