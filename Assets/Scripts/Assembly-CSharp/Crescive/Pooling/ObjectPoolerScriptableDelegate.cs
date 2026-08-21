using UnityEngine;

namespace Crescive.Pooling
{
	[CreateAssetMenu(menuName = "Pooling/ObjectPoolerScriptableDelegate", fileName = "ObjectPoolerScriptableDelegate")]
	public class ObjectPoolerScriptableDelegate : ScriptableObject, IObjectPooler
	{
		[SerializeField]
		private GameObjectPooler.PoolItem poolItem;

		private ObjectPoolerBehaviour objectPoolerBehaviour;

		public GameObjectPooler.PoolItem PoolItem => default(GameObjectPooler.PoolItem);

		public GameObject Prefab => null;

		private bool CheckIfNotInitialized()
		{
			return false;
		}

		public void SetData(ObjectPoolerBehaviour poolerBehaviour)
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

		public GameObject SpawnWithAutoDespawn(float? despawnDuration = null)
		{
			return null;
		}

		public void Despawn(GameObject spawnedObject)
		{
		}

		public void Despawn<T>(T spawnedObject) where T : Component
		{
		}

		public void DespawnDelayed(GameObject obj, float delay)
		{
		}

		public void DespawnAll()
		{
		}

		public bool IsObjectFromPool(GameObject gameObject)
		{
			return false;
		}
	}
}
