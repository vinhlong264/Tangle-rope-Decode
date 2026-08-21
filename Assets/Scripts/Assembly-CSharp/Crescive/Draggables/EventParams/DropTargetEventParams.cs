using System;

namespace Crescive.Draggables.EventParams
{
	[Serializable]
	public class DropTargetEventParams
	{
		public DropTarget DropTarget;

		public DropTargetEventParams(DropTarget dropTarget)
		{
		}
	}
}
