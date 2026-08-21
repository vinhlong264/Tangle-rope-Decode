using UnityEngine;

namespace Crescive.Draggables
{
	public class OccupationDropTargetFilter : BaseDragFilter
	{
		[SerializeField]
		private BaseDropTargetHolder holder;

		public override bool CanDrag(Draggable draggable)
		{
			return false;
		}
	}
}
