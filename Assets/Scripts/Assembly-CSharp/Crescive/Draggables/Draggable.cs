using System.Collections.Generic;
using Systems.ColorGameMode;
using Crescive.Draggables.EventParams;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	[DefaultExecutionOrder(-10)]
	public class Draggable : MonoBehaviour, IDraggableDelegate
	{
		[SerializeField]
		private GameObject targetGameObject;

		[SerializeField]
		private Transform dragOffset;

		[SerializeField]
		private BaseDraggableTransformUpdater transformUpdater;

		[SerializeField]
		private DraggableDropRayMode dropRayMode;

		[SerializeField]
		private bool initialCanDrag;

		[SerializeField]
		private List<BaseDragFilter> dragCancelFilters;

		[SerializeField]
		private List<AtomCondition> dragCancelConditions;

		private RopeColorController ropeColorController;

		public int ColorIndex;

		internal DefaultDropTargetHolder placed;

		private bool canDrag;

		private Vector3 dragStartPosition;

		public UnityEvent<DraggableEventParams> OnSelected;

		public UnityEvent<DraggableEventParams> OnGrabbed;

		public UnityEvent<DraggableDropEventParams> OnDragged;

		public UnityEvent<DraggableDropEventParams> OnDropTargetSelected;

		public UnityEvent<DraggableDropEventParams> OnDropTargetUnselected;

		public UnityEvent<DraggableDropEventParams> OnDropped;

		public UnityEvent<DraggableEventParams> OnUnselected;

		public UnityEvent<DraggableEventParams> OnUnselectedWithoutGrab;

		public UnityEvent<DraggableEventParams> OnCanSelect;

		public UnityEvent<DraggableEventParams> OnCanNotSelect;

		public RopeColorController RopeColorController => null;

		public DraggableDropRayMode DropRayMode => default(DraggableDropRayMode);

		public bool IsGrabbed { get; set; }

		public bool CanDrag => false;

		public GameObject TargetGameObject => null;

		public Draggable TargetDraggable => null;

		public Bounds HitBounds => default(Bounds);

		public Vector3 DragStartPosition => default(Vector3);

		private void Awake()
		{
		}

		public void SetCanDrag(bool value)
		{
		}

		public void UpdateTransform(Vector3 raycastHitPoint)
		{
		}

		public void SetDragStartPosition(Vector3 position)
		{
		}

		public bool CanCancelDrag()
		{
			return false;
		}
	}
}
