using System;

namespace Crescive.Draggables.EventParams
{
	[Serializable]
	public class HolderEventParams
	{
		public BaseDropTargetHolder Holder;

		public Draggable Draggable;

		public HolderEventParams(BaseDropTargetHolder holder, Draggable draggable)
		{
		}
	}
}
