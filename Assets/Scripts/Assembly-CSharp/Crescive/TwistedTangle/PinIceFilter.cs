using Crescive.Draggables;

namespace Crescive.TwistedTangle
{
	public class PinIceFilter : BaseDragFilter
	{
		public override bool CanDrag(Draggable draggable)
		{
			return false;
		}
	}
}
