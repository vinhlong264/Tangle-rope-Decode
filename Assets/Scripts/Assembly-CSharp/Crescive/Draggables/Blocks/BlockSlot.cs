using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables.Blocks
{
	public class BlockSlot : MonoBehaviour
	{
		[SerializeField]
		private Transform blockParent;

		[SerializeField]
		private Block currentBlock;

		[SerializeField]
		private bool isSelected;

		public UnityEvent OnSelected;

		public UnityEvent OnDeselected;

		public UnityEvent<Block> OnSetCurrentBlock;

		public Transform BlockParent => null;

		public bool IsOccupied => false;

		public Block CurrentBlock => null;

		public void SetCurrentBlock(Block block)
		{
		}

		public void SetSelected(bool value)
		{
		}
	}
}
