using UnityEngine;

namespace Crescive.Pooling
{
	public interface IObjectPooler
	{
		GameObject Prefab { get; }

		GameObject Spawn();

		T Spawn<T>() where T : Component;

		GameObject SpawnWithAutoDespawn(float? despawnDuration = null);

		void Despawn(GameObject obj);

		void Despawn<T>(T obj) where T : Component;

		void DespawnDelayed(GameObject obj, float delay);

		void DespawnAll();

		bool IsObjectFromPool(GameObject gameObject);
	}
}
