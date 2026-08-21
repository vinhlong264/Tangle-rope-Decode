using System;

namespace Crescive.Draggables.EventParams
{
	[Serializable]
	public class HolderDropAnotherEventParams : HolderEventParams
	{
		public BaseDropTargetHolder OtherHolder;

		public HolderDropAnotherEventParams(BaseDropTargetHolder holder, Draggable draggable, BaseDropTargetHolder otherHolder)
			: base(null, null)
		{
		}
	}
}
