using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DropTargetHolderChannel", menuName = "Draggables/Channel/DropTargetHolderChannel")]
	public class DropTargetHolderChannel : ScriptableObject
	{
		[SerializeField]
		private BaseDropTargetHolder holder;

		public BaseDropTargetHolder Holder => null;

		public void SetHolder(BaseDropTargetHolder dropTargetHolder)
		{
		}
	}
}
