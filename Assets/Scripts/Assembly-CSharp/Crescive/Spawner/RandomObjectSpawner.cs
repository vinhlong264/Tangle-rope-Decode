using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Spawner
{
	public class RandomObjectSpawner : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> prefabs;

		[SerializeField]
		private Transform parent;

		[SerializeField]
		private bool autoSpawnAtAwake;

		private void Awake()
		{
		}

		public void Spawn()
		{
		}
	}
}
