using System.Collections.Generic;
using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables.Blocks
{
	[DefaultExecutionOrder(-100000000)]
	public class BlockGrid : MonoBehaviour
	{
		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private BlockSlot[] blockSlots;

		[SerializeField]
		private bool autoSetup;

		[SerializeField]
		private float maximumDistance;

		public UnityEvent OnSetupCompleted;

		public BlockSlot[] BlockSlots => null;

		public bool IsFull => false;

		public bool IsGridEmpty => false;

		public bool HasEmptySlot => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private Dictionary<int, BlockSlot> GetClosestSlotsToGroup(BlockGroup group)
		{
			return null;
		}

		private BlockSlot GetClosestSlotToBlockPoint(Block block)
		{
			return null;
		}

		private void OnDragCallback(DraggableDropEventParams args)
		{
		}

		public void Setup()
		{
		}
	}
}
