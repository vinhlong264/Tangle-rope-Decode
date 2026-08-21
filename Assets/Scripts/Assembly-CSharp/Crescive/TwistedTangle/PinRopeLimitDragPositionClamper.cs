using Crescive.Draggables;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "PinRopeLimitDragPositionClamper", menuName = "Draggables/Updater/DragPositionClamper/PinRopeLimitDragPositionClamper")]
	public class PinRopeLimitDragPositionClamper : BaseDragPositionClamper
	{
		[SerializeField]
		private FloatVariableReference maxDistance;

		public float MaxDistance => 0f;

		private Vector3 ClampBasedOnOtherPin(PinEntity pin, Vector3 position)
		{
			return default(Vector3);
		}

		private Vector3 ClampPositionBasedOnPinsDistance(PinEntity other, Vector3 position)
		{
			return default(Vector3);
		}

		public override Vector3 ClampPosition(Draggable draggable, Vector3 position)
		{
			return default(Vector3);
		}
	}
}
