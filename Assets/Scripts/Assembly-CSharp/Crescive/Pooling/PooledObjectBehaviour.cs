using UnityEngine;

namespace Crescive.Pooling
{
	public class PooledObjectBehaviour : MonoBehaviour, IPooledObject
	{
		public GameObjectPooler Pooler { get; set; }

		public GameObject GameObject => null;

		public void Despawn()
		{
		}
	}
}
