using System;
using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public abstract class BaseDropTargetHolder : MonoBehaviour
	{
		[SerializeField]
		private DropTargetHolderChannel channel;

		[SerializeField]
		protected DropTarget dropTarget;

		[SerializeField]
		private bool isDropImmediate;

		[SerializeField]
		private bool isPlaceBackImmediate;

		[SerializeField]
		private bool triggerPlacedEventOnDropped;

		public UnityEvent<HolderEventParams> OnHeld;

		public UnityEvent<HolderEventParams> OnHoldPlaced;

		public UnityEvent<HolderEventParams> OnPlaced;

		public UnityEvent<HolderEventParams> OnRemoved;

		public UnityEvent<HolderDropAnotherEventParams> OnDroppedToAnotherTarget;

		public DropTarget DropTarget => null;

		public abstract bool IsOccupied { get; }

		public bool IsEmpty => false;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDroppedHere(DraggableDropEventParams args)
		{
		}

		protected virtual void TriggerHeldEvent(Draggable draggable)
		{
		}

		protected virtual void TriggerHoldPlacedEvent(Draggable draggable)
		{
		}

		protected virtual void TriggerPlacedEvent(Draggable draggable)
		{
		}

		protected virtual void TriggerRemovedEvent(Draggable draggable)
		{
		}

		public void SetDropTarget(DropTarget t)
		{
		}

		public void Hold(Draggable draggable, bool immediate)
		{
		}

		private void OnDraggableDropped(DraggableDropEventParams args)
		{
		}

		public void Remove(Draggable draggable)
		{
		}

		protected virtual void OnDraggableSelectedInternal(DraggableEventParams args)
		{
		}

		protected virtual void OnDraggableGrabbedInternal(DraggableEventParams args)
		{
		}

		protected virtual void OnDraggableDroppedInternal(DraggableDropEventParams args)
		{
		}

		protected abstract void HoldInternal(Draggable draggable);

		protected abstract void RemoveInternal(Draggable draggable);

		protected abstract void Place(Draggable draggable, bool immediate, Action callback);

		public abstract void TryPlaceExternal(Draggable draggable, bool immediate);

		public abstract void RemoveAll();

		public abstract bool HasDraggable(Draggable draggable);
	}
}
