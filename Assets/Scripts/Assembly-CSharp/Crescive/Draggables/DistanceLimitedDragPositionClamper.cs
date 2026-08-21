using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DistanceLimitedDragPositionClamper", menuName = "Draggables/Updater/DragPositionClamper/DistanceLimitedDragPositionClamper")]
	public class DistanceLimitedDragPositionClamper : BaseDragPositionClamper
	{
		[SerializeField]
		private float maxDistance;

		public override Vector3 ClampPosition(Draggable draggable, Vector3 position)
		{
			return default(Vector3);
		}
	}
}
