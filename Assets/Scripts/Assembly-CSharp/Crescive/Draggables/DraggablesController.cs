using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.Inputs;
using UnityEngine;

namespace Crescive.Draggables
{
	[DefaultExecutionOrder(1)]
	public class DraggablesController : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private PlayerInputData inputData;

		[SerializeField]
		private DraggableRaycaster raycaster;

		[SerializeField]
		private DropTargetsChannel dropTargetsChannel;

		[SerializeField]
		private List<BoolVariableReference> disableConditions;

		[SerializeField]
		[Header("Settings")]
		private bool fixedUpdate;

		[SerializeField]
		private bool ignorePointerOverUI;

		[SerializeField]
		private Vector3 lockedAxis;

		[SerializeField]
		private bool xLocked;

		[SerializeField]
		private bool yLocked;

		[SerializeField]
		private bool zLocked;

		[SerializeField]
		private float dragThreshold;

		private bool tapped;

		private bool holding;

		private bool released;

		private float currentDraggedDistance;

		public bool Input { get; set; }

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleInput()
		{
		}

		private bool IsPointerOverUI()
		{
			return false;
		}

		private bool HitsContainsViableDropTargets(RaycastHit[] raycastHits, out RaycastHit[] viableHits)
		{
			viableHits = null;
			return false;
		}

		private void HandleOnTap()
		{
		}

		private void HandleOnHold()
		{
		}

		private void HandleOnRelease()
		{
		}

		private void ReleaseDraggable()
		{
		}

		private bool TrySelectDraggable(RaycastHit raycastHit)
		{
			return false;
		}

		private void HandleGrab(Draggable draggable)
		{
		}

		private void HandleDrag(Vector3 raycastHitPoint)
		{
		}

		private void SelectClosestDropTarget(RaycastHit[] raycastHits)
		{
		}

		private void HandleDrop()
		{
		}

		private void UnselectCurrentDropTarget(bool unsetCurrentDropTarget = true)
		{
		}

		private void UngrabCurrentDraggable(bool unsetCurrentDraggable = true)
		{
		}

		private void UnselectCurrentDraggable()
		{
		}

		private void SetDropTargetIndicators(IEnumerable<DropTarget> dropTargets, bool active)
		{
		}

		private void CancelDrag()
		{
		}

		public void SetDragThreshold(float threshold)
		{
		}

		public void UnselectCurrentDropTarget()
		{
		}

		public void ForceCancelDrag()
		{
		}

		private static DropTarget GetClosestDropTargetToPosition(RaycastHit[] dropTargetHits, Vector3 position)
		{
			return null;
		}
	}
}
