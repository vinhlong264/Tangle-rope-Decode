using Crescive.Inputs;
using Obi;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeRaycaster : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PlayerInputData inputData;

		[SerializeField]
		private BoolReference enable;

		[SerializeField]
		private float horizontalScreenLinePercent;

		[SerializeField]
		private RopeRaycasterChannel ropeRaycasterChannel;

		public UnityEvent<RopeEntity> OnClickedRope;

		public UnityEvent<RopeRaycastData> OnClickedRopeWithData;

		private void HandleRaycast()
		{
		}

		private bool RaycastRope(RopeEntity ropeEntity, out ObiStructuralElement hitElement)
		{
			hitElement = null;
			return false;
		}

		private bool IsElementIntersectingWithScreenTap(Vector2 leftScreenPosition, Vector2 rightScreenPosition, Vector2 upScreenPosition, Vector2 downScreenPosition, ObiRope rope, ObiStructuralElement element, Camera cam)
		{
			return false;
		}

		private bool SegmentSegmentIntersection(Vector2 A, Vector2 B, Vector2 C, Vector2 D, out float r, out float s)
		{
			r = default(float);
			s = default(float);
			return false;
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void SetEnable(bool value)
		{
		}
	}
}
