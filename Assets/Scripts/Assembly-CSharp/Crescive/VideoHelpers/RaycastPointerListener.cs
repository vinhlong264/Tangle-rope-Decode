using UnityEngine;
using UnityEngine.Events;

namespace Crescive.VideoHelpers
{
	public class RaycastPointerListener : MonoBehaviour
	{
		[SerializeField]
		private LayerMask fieldMask;

		public UnityEvent<Vector3> OnRaycastHitEvent;

		private void Update()
		{
		}

		private void HandleRaycasts()
		{
		}

		private bool RaycastField(out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}
	}
}
