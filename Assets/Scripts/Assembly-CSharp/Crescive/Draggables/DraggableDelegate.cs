using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public class DraggableDelegate : MonoBehaviour, IDraggableDelegate
	{
		[SerializeField]
		private Draggable draggable;

		public UnityEvent<Draggable> OnSetTargetDraggable;

		public UnityEvent OnSetTargetDraggableValid;

		public UnityEvent OnSetTargetDraggableNull;

		public Draggable TargetDraggable => null;

		public Bounds HitBounds => default(Bounds);

		public void SetTargetDraggable(Draggable targetDraggable)
		{
		}
	}
}
