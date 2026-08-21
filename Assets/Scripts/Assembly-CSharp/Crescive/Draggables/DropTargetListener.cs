using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public class DropTargetListener : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private DropTarget dropTarget;

		[Header("Events")]
		public UnityEvent<Draggable> OnDropTargetSelected;

		public UnityEvent<Draggable> OnDropTargetUnselected;

		[Space]
		public UnityEvent OnEnableIndicator;

		public UnityEvent OnDisableIndicator;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDropTargetSelectedCallback(DraggableDropEventParams args)
		{
		}

		private void OnDropTargetUnselectedCallback(DraggableDropEventParams args)
		{
		}

		private void OnEnableIndicatorCallback()
		{
		}

		private void OnDisableIndicatorCallback()
		{
		}
	}
}
