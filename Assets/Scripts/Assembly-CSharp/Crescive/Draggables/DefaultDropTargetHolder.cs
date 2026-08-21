using System;
using Systems.ColorGameMode;
using Crescive.Draggables.EventParams;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Draggables
{
	public class DefaultDropTargetHolder : BaseDropTargetHolder
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private ObjectTransferer transferer;

		internal PinSlotEntity PinSlotEntity;

		public int ColorIndex;

		private bool draggableHoldFromAnotherTarget;

		[field: SerializeField]
		public Draggable CurrentDraggable { get; private set; }

		[field: SerializeField]
		public bool IsDraggablePlaced { get; private set; }

		public bool IsDraggablePlacing => false;

		public override bool IsOccupied => false;

		protected override void HoldInternal(Draggable draggable)
		{
		}

		protected override void RemoveInternal(Draggable draggable)
		{
		}

		protected override void Place(Draggable draggable, bool immediate, Action callback)
		{
		}

		private static void CheckUpdateColors(RopeColorController ropeColorController)
		{
		}

		public override void TryPlaceExternal(Draggable draggable, bool immediate)
		{
		}

		protected override void OnDraggableSelectedInternal(DraggableEventParams args)
		{
		}

		protected override void OnDraggableGrabbedInternal(DraggableEventParams args)
		{
		}

		public override void RemoveAll()
		{
		}

		public override bool HasDraggable(Draggable draggable)
		{
			return false;
		}

		private void PlaceImmediate(Draggable draggable)
		{
		}

		public void SetTarget(Transform t)
		{
		}
	}
}
