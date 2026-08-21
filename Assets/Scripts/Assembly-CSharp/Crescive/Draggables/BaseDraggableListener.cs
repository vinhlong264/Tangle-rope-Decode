using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public abstract class BaseDraggableListener : MonoBehaviour
	{
		public UnityEvent<DraggableEventParams> OnSelected;

		public UnityEvent<DraggableEventParams> OnGrabbed;

		public UnityEvent<DraggableEventParams> OnDragged;

		public UnityEvent<DraggableDropEventParams> OnDropped;

		public UnityEvent<DraggableDropEventParams> OnDropTargetSelected;

		public UnityEvent<DraggableDropEventParams> OnDropTargetUnselected;

		public UnityEvent<DraggableEventParams> OnUnselected;

		public UnityEvent<DraggableEventParams> OnUnselectedWithoutGrab;

		public UnityEvent<DraggableEventParams> OnCanSelect;

		public UnityEvent<DraggableEventParams> OnCanNotSelect;

		protected abstract IDraggableDelegate DraggableDelegate { get; }

		public Draggable Draggable => null;

		protected bool DidSubscribe { get; private set; }

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void SubscribeToDraggable()
		{
		}

		protected void UnsubscribeFromDraggable()
		{
		}

		private void OnSelectedCallback(DraggableEventParams arg0)
		{
		}

		private void OnGrabbedCallback(DraggableEventParams arg0)
		{
		}

		private void OnDraggedCallback(DraggableEventParams arg0)
		{
		}

		private void OnDroppedCallback(DraggableDropEventParams arg0)
		{
		}

		private void OnDropTargetSelectedCallback(DraggableDropEventParams arg0)
		{
		}

		private void OnDropTargetUnselectedCallback(DraggableDropEventParams arg0)
		{
		}

		private void OnUnselectedCallback(DraggableEventParams arg0)
		{
		}

		private void OnUnselectedWithoutGrabCallback(DraggableEventParams arg0)
		{
		}

		private void OnCanSelectCallback(DraggableEventParams arg0)
		{
		}

		private void OnCanNotSelectCallback(DraggableEventParams arg0)
		{
		}
	}
}
