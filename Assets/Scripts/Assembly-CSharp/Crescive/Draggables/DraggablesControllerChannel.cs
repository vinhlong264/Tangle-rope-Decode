using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DraggablesControllerChannel", menuName = "Draggables/Channel/DraggablesControllerChannel")]
	public class DraggablesControllerChannel : ScriptableObject
	{
		public UnityEvent<DraggableEventParams> OnTapDraggable;

		public UnityEvent<DraggableEventParams> OnSelect;

		public UnityEvent<DraggableEventParams> OnGrab;

		public UnityEvent<DraggableDropEventParams> OnDrag;

		public UnityEvent<DraggableDropEventParams> OnDrop;

		public UnityEvent<DraggableDropEventParams> OnDropTargetSelected;

		public UnityEvent<DraggableDropEventParams> OnDropTargetUnselected;

		public UnityEvent<DraggableEventParams> OnUnselect;

		public UnityEvent<DraggableEventParams> OnUnselectWithoutGrab;

		public UnityEvent<DropTargetEventParams> OnTapDropTarget;

		[SerializeField]
		private Draggable currentDraggable;

		[SerializeField]
		private DropTarget currentDropTarget;

		[SerializeField]
		private bool dragThresholdReached;

		public DraggablesController Controller { get; private set; }

		public Draggable CurrentDraggable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DropTarget CurrentDropTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool DragThresholdReached
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDraggingObject => false;

		public void SetController(DraggablesController controller)
		{
		}

		public void ClearData()
		{
		}

		public void SetInput(bool open)
		{
		}

		public void ActivateController()
		{
		}

		public void DeactivateController()
		{
		}

		public void ToggleController(bool active)
		{
		}
	}
}
