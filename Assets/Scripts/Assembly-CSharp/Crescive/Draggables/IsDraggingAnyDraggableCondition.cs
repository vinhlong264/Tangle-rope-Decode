using UnityAtoms;
using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "HasAnyDraggableCondition", menuName = "Crescive/Draggables/Conditions/HasAnyDraggableCondition")]
	public class IsDraggingAnyDraggableCondition : AtomCondition
	{
		[SerializeField]
		private DraggablesControllerChannel channel;

		public override bool Call()
		{
			return false;
		}
	}
}
