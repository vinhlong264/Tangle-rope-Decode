using System;
using System.Collections.Generic;
using Crescive.Prefabs;
using UnityEngine;

namespace Crescive.Pooling
{
	public class GameObjectPooler
	{
		[Serializable]
		public struct PoolItem
		{
			[SerializeField]
			private bool UsePrefabSource;

			[SerializeField]
			private GameObject prefab;

			[SerializeField]
			private PrefabSource prefabSource;

			public int initialSize;

			public int maxCapacity;

			public PoolItemMaxCapacityBehaviourType maxCapacityBehaviour;

			public GameObject Prefab => null;
		}

		public enum PoolItemMaxCapacityBehaviourType
		{
			Overgrow = 0,
			DespawnOldest = 1
		}

		private Queue<GameObject> pool;

		private List<GameObject> spawnedObjects;

		private int currentCapacity;

		private PoolItem poolItem;

		private Transform poolParent;

		public GameObjectPooler(PoolItem item, Transform parent)
		{
		}

		public GameObject Spawn()
		{
			return null;
		}

		public T Spawn<T>() where T : Component
		{
			return null;
		}

		public void Despawn(GameObject spawnedObject)
		{
		}

		public void Despawn<T>(T obj) where T : Component
		{
		}

		public void DespawnAll()
		{
		}

		public bool IsObjectFromPool(GameObject obj)
		{
			return false;
		}

		private void HandleCapacity()
		{
		}

		private void Initialize()
		{
		}

		private void Grow(int count)
		{
		}

		private void Grow()
		{
		}

		private void DespawnOldest()
		{
		}
	}
}
