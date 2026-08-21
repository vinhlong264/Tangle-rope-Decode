using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinsTapMoveDropFilter : BaseDragFilter
	{
		[SerializeField]
		private PinSlotEntity pinSlot;

		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		public override bool CanDrag(Draggable _)
		{
			return false;
		}
	}
}
