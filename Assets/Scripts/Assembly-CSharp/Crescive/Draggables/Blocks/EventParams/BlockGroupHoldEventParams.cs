using System;

namespace Crescive.Draggables.Blocks.EventParams
{
	[Serializable]
	public class BlockGroupHoldEventParams
	{
		public BlockGroup BlockGroup;

		public BlockGridDropTargetHolder Holder;

		public BlockGroupHoldEventParams(BlockGroup blockGroup, BlockGridDropTargetHolder holder)
		{
		}
	}
}
