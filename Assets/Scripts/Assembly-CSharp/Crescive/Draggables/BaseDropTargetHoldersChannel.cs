using System.Collections.Generic;
using Crescive.Channels;

namespace Crescive.Draggables
{
	public abstract class BaseDropTargetHoldersChannel<THolder> : ObjectsChannel<THolder> where THolder : BaseDropTargetHolder
	{
		public int OccupiedSlotsCount => 0;

		public int EmptySlotsCount => 0;

		public THolder GetDraggableHolder(Draggable draggable)
		{
			return null;
		}

		public Holder GetDraggableHolder<Holder>(Draggable draggable) where Holder : THolder
		{
			return null;
		}

		public List<THolder> GetActiveHolders()
		{
			return null;
		}

		public BaseDropTargetHolder GetHolderByDraggable(Draggable draggable)
		{
			return null;
		}

		public bool HasDraggableHolder(Draggable draggable)
		{
			return false;
		}

		public bool TryRemoveDraggable(Draggable draggable)
		{
			return false;
		}
	}
}
