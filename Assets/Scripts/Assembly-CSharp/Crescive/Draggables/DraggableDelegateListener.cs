using UnityEngine;

namespace Crescive.Draggables
{
	public class DraggableDelegateListener : BaseDraggableListener
	{
		[SerializeField]
		private DraggableDelegate draggableDelegate;

		protected override IDraggableDelegate DraggableDelegate => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnSetTargetDraggableCallback(Draggable targetDraggable)
		{
		}
	}
}
