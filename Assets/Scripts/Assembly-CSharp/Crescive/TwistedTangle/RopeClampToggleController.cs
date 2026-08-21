using Crescive.Inputs;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeClampToggleController : MonoBehaviour
	{
		[SerializeField]
		private ClampEntity clampEntityPrefab;

		[SerializeField]
		private PlayerInputData inputData;

		[SerializeField]
		private LayerMask fieldMask;

		[SerializeField]
		private LayerMask clampMask;

		[SerializeField]
		private float sphereCastRadius;

		[SerializeField]
		private bool autoDeactivate;

		[SerializeField]
		private float rotateAmount;

		[SerializeField]
		private float initialClampScale;

		[SerializeField]
		private float clampScaleFixDuration;

		private ClampEntity currentClamp;

		private bool active;

		public UnityEvent OnActivated;

		public UnityEvent OnDeactivated;

		public UnityEvent<bool> OnActivationChanged;

		private void Update()
		{
		}

		private void HandleInputs()
		{
		}

		private void HandleTap()
		{
		}

		private void HandleDrag()
		{
		}

		private void HandleRelease()
		{
		}

		private bool TryToCreateClamp()
		{
			return false;
		}

		private bool TryDestroyingClampIfThereIs()
		{
			return false;
		}

		private bool RaycastField(out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		private bool SphereCastClamp(out RaycastHit[] hits)
		{
			hits = null;
			return false;
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void Toggle()
		{
		}
	}
}
