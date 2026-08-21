using System;
using System.Collections.Generic;
using Crescive.Draggables.EventParams;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables.Blocks
{
	public class BlockGridDropTargetHolder : BaseDropTargetHolder
	{
		[SerializeField]
		private BlockGridTransferer blockGridTransferer;

		[SerializeField]
		private List<BlockGroup> currentBlockGroups;

		private Dictionary<BlockGroup, Sequence> blockGroupSequences;

		public UnityEvent<Block> OnBlockPlacingToSlot;

		public UnityEvent<Block> OnBlockPlacedToSlot;

		public override bool IsOccupied => false;

		private BlockGroup GetBlockGroup(Draggable draggable)
		{
			return null;
		}

		private void PlaceBlockGroupOnCurrentBlockSlots(BlockGroup blockGroup)
		{
		}

		private void PlaceBlockGroupBlocksToCurrentBlockSlotsImmediate(BlockGroup blockGroup, Action callback)
		{
		}

		private void PlaceBlockGroupBlocksToCurrentBlockSlotsAnimated(BlockGroup blockGroup, Action callback)
		{
		}

		protected override void HoldInternal(Draggable draggable)
		{
		}

		protected override void OnDraggableGrabbedInternal(DraggableEventParams args)
		{
		}

		protected override void RemoveInternal(Draggable draggable)
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
