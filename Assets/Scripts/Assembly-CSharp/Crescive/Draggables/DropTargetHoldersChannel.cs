using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DropTargetHoldersChannel", menuName = "Draggables/Channel/DropTargetHoldersChannel")]
	public class DropTargetHoldersChannel : BaseDropTargetHoldersChannel<BaseDropTargetHolder>
	{
		public BaseDropTargetHolder GetClosestDropTargetHolder(Vector3 point)
		{
			return null;
		}

		public BaseDropTargetHolder GetClosestActiveDropTargetHolder(Vector3 point)
		{
			return null;
		}

		public bool TryHoldClosestActiveDropTargetHolder(Draggable draggable)
		{
			return false;
		}
	}
}
