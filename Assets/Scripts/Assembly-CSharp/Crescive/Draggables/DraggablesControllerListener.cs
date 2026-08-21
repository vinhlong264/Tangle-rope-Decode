using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public class DraggablesControllerListener : MonoBehaviour
	{
		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		public UnityEvent<DraggableEventParams> OnTapDraggable;

		public UnityEvent<Draggable> OnSelect;

		public UnityEvent<Draggable> OnGrab;

		public UnityEvent<Draggable> OnDrag;

		public UnityEvent<Draggable, DropTarget> OnDrop;

		public UnityEvent<DropTarget> OnDropTargetSelected;

		public UnityEvent<DropTarget> OnDropTargetUnselected;

		public UnityEvent<Draggable> OnUnselect;

		public UnityEvent<Draggable> OnUnselectWithoutGrab;

		public UnityEvent<DropTargetEventParams> OnTapDropTarget;

		public UnityEvent<GameObject> OnSelectGO;

		public UnityEvent<GameObject> OnGrabGO;

		public UnityEvent<GameObject> OnDragGO;

		public UnityEvent<GameObject, GameObject> OnDropGO;

		public UnityEvent<GameObject> OnDropTargetSelectedGO;

		public UnityEvent<GameObject> OnDropTargetUnselectedGO;

		public UnityEvent<GameObject> OnUnselectGO;

		public UnityEvent<GameObject> OnUnselectWithoutGrabGO;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTapDraggableCallback(DraggableEventParams args)
		{
		}

		private void OnSelectCallback(DraggableEventParams args)
		{
		}

		private void OnGrabCallback(DraggableEventParams args)
		{
		}

		private void OnDragCallback(DraggableDropEventParams args)
		{
		}

		private void OnDropCallback(DraggableDropEventParams args)
		{
		}

		private void OnDropTargetSelectedCallback(DraggableDropEventParams args)
		{
		}

		private void OnDropTargetUnselectedCallback(DraggableDropEventParams args)
		{
		}

		private void OnUnselectCallback(DraggableEventParams args)
		{
		}

		private void OnUnselectWithoutGrabCallback(DraggableEventParams args)
		{
		}

		private void OnTapDropTargetCallback(DropTargetEventParams args)
		{
		}
	}
}
