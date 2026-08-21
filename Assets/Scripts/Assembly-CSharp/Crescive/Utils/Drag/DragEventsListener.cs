using Crescive.Inputs;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils.Drag
{
	public class DragEventsListener : MonoBehaviour
	{
		[SerializeField]
		private LayerMask rayFieldMask;

		[SerializeField]
		private PlayerInputData playerInputData;

		public UnityEvent<Vector3> OnDragStartedEvent;

		public UnityEvent<Vector3> OnDraggingEvent;

		public UnityEvent<Vector3> OnDragEndedEvent;

		private bool dragging;

		private void Update()
		{
		}

		private void HandleDragging()
		{
		}

		private void OnTapped()
		{
		}

		private void OnHolding()
		{
		}

		private void OnReleased()
		{
		}

		private void OnDragtarted()
		{
		}

		private void OnDragging()
		{
		}

		private void OnDragEnded()
		{
		}

		private bool TryToDrag(out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public void ReleaseDragging()
		{
		}
	}
}
