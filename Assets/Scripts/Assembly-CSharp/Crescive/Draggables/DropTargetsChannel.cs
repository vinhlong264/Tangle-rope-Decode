using System.Collections.Generic;
using Crescive.Channels;
using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DropTargetsChannel", menuName = "Draggables/Channel/DropTargetsChannel")]
	public class DropTargetsChannel : ObjectsChannel<DropTarget>
	{
		public List<DropTarget> GetFilteredDropTargets(Draggable draggable)
		{
			return null;
		}

		public DropTarget GetFilteredClosestDropTarget(Draggable draggable)
		{
			return null;
		}

		public DropTarget GetClosestDropTarget(Draggable draggable)
		{
			return null;
		}
	}
}
