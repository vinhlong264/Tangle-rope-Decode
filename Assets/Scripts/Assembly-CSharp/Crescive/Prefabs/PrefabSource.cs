using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Prefabs
{
	[CreateAssetMenu(fileName = "PrefabSource", menuName = "Crescive/Prefabs/Source")]
	public class PrefabSource : ScriptableObject
	{
		[SerializeField]
		private GameObject prefab;

		[SerializeField]
		private List<CondionalPrefab> conditionalPrefabs;

		public GameObject Prefab => null;

		private GameObject GetPrefab()
		{
			return null;
		}

		public T GetPrefab<T>() where T : Component
		{
			return null;
		}
	}
}
