using UnityEngine;

namespace Crescive.Leveling
{
	public class LevelingSpawnerPositioner : MonoBehaviour
	{
		[SerializeField]
		private LevelingObjectSpawner spawner;

		[SerializeField]
		private Vector3 size;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnSpawned(LevelingBehaviour levelingBehaviour)
		{
		}
	}
}
