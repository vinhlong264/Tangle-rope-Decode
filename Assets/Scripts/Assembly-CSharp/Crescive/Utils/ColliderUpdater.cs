using UnityEngine;

namespace Crescive.Utils
{
	public class ColliderUpdater : MonoBehaviour
	{
		[SerializeField]
		private float updatePeriod;

		[SerializeField]
		private MeshFilter meshFilter;

		[SerializeField]
		private MeshCollider meshCollider;

		private float timer;

		private void Update()
		{
		}

		private void UpdateCollider()
		{
		}

		private void TryUpdatingByTimer()
		{
		}

		public void SetUpdatePeriod(float period)
		{
		}
	}
}
