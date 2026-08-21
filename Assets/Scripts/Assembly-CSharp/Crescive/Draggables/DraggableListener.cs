using UnityEngine;

namespace Crescive.Draggables
{
	public class DraggableListener : BaseDraggableListener
	{
		[SerializeField]
		private Draggable draggable;

		protected override IDraggableDelegate DraggableDelegate => null;
	}
}
