using System;
using System.Collections.Generic;
using Crescive.Draggables.EventParams;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Draggables
{
	public class FreeDropTargetHolder : BaseDropTargetHolder
	{
		[SerializeField]
		private List<Draggable> currentDraggables;

		[SerializeField]
		private int maxDraggableCount;

		[SerializeField]
		private Transform placeParent;

		[SerializeField]
		private float smoothPlaceDuration;

		[SerializeField]
		private Ease smoothPlaceEase;

		private Dictionary<Draggable, Sequence> draggableSequences;

		public override bool IsOccupied => false;

		protected override void HoldInternal(Draggable draggable)
		{
		}

		protected override void RemoveInternal(Draggable draggable)
		{
		}

		protected override void OnDraggableGrabbedInternal(DraggableEventParams args)
		{
		}

		protected override void Place(Draggable draggable, bool immediate, Action callback)
		{
		}

		public override void TryPlaceExternal(Draggable draggable, bool immediate)
		{
		}

		public override void RemoveAll()
		{
		}

		public override bool HasDraggable(Draggable draggable)
		{
			return false;
		}
	}
}
