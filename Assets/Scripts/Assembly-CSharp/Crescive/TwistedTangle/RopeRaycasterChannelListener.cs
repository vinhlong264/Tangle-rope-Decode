using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeRaycasterChannelListener : MonoBehaviour
	{
		[SerializeField]
		private RopeRaycasterChannel raycasterChannel;

		public UnityEvent<RopeEntity> OnClickedRope;

		public UnityEvent<RopeRaycastData> OnClickedRopeWithData;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
