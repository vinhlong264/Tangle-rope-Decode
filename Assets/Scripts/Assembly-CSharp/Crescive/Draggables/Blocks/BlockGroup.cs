using System.Collections.Generic;
using Crescive.Draggables.Blocks.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables.Blocks
{
	public class BlockGroup : MonoBehaviour, IDropTargetHolderHeldListener, IDropTargetHolderPlacedListener, IDropTargetHolderRemovedListener
	{
		[SerializeField]
		private Draggable draggable;

		[SerializeField]
		private Transform blocksParent;

		[SerializeField]
		private Block[] blocks;

		[SerializeField]
		private Vector3 blockPointOffset;

		[SerializeField]
		private Block[] blocksOrdered;

		[SerializeField]
		private BaseDropTargetHolder currentHolder;

		[SerializeField]
		private List<BlockSlot> closestBlockSlotsList;

		[SerializeField]
		private List<BlockSlot> currentBlockSlotsList;

		private Dictionary<int, BlockSlot> closestBlockSlots;

		private Dictionary<int, BlockSlot> currentBlockSlots;

		public UnityEvent<BlockGroupHoldEventParams> OnHeldByGrid;

		public UnityEvent<BlockGroupHoldEventParams> OnPlacedOnGrid;

		public UnityEvent<BlockGroupHoldEventParams> OnRemovedFromGrid;

		public Draggable Draggable => null;

		public Transform BlocksParent => null;

		public Block[] Blocks => null;

		public Block[] BlocksOrdered => null;

		public Dictionary<int, BlockSlot> ClosestBlockSlots => null;

		public Dictionary<int, BlockSlot> CurrentBlockSlots => null;

		public BaseDropTargetHolder CurrentHolder => null;

		public Vector3 BlockPointOffset => default(Vector3);

		public bool HasCurrentBlockSlots => false;

		public bool HasAllBlocksClosestBlockSlots => false;

		private void Awake()
		{
		}

		private void SetupBlocks()
		{
		}

		public void ResetBlockGroupParents()
		{
		}

		public void SetCurrentHolder(BaseDropTargetHolder holder)
		{
		}

		public void SetClosestBlockSlots(Dictionary<int, BlockSlot> slots)
		{
		}

		public void SelectClosestBlockSlots()
		{
		}

		public void UnselectClosestBlockSlots()
		{
		}

		public void SetCurrentBlockSlots(Dictionary<int, BlockSlot> slots)
		{
		}

		public BlockSlot GetBlockSlotForBlock(Block block)
		{
			return null;
		}

		public BlockSlot GetClosestBlockSlotForBlock(Block block)
		{
			return null;
		}

		public void OnDropTargetHolderHeld(DropTarget dropTarget)
		{
		}

		public void OnDropTargetHolderPlaced(DropTarget dropTarget)
		{
		}

		public void OnDropTargetHolderRemoved(DropTarget dropTarget)
		{
		}
	}
}
