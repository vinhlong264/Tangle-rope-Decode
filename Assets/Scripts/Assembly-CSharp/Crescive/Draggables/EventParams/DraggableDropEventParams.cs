using System;

namespace Crescive.Draggables.EventParams
{
	[Serializable]
	public class DraggableDropEventParams : DraggableEventParams
	{
		public DropTarget DropTarget;

		public DraggableDropEventParams(Draggable draggable)
			: base(null)
		{
		}

		public DraggableDropEventParams(Draggable draggable, DropTarget dropTarget)
			: base(null)
		{
		}
	}
}
