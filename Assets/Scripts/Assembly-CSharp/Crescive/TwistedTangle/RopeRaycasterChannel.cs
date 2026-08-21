using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(menuName = "Crescive/TwistedTangle/Rope/RopeRaycasterChannel")]
	public class RopeRaycasterChannel : ScriptableObject
	{
		public UnityEvent<RopeEntity> OnClickedRope;

		public UnityEvent<RopeRaycastData> OnClickedRopeWithData;

		public void TriggerOnClickedRope(RopeEntity rope)
		{
		}

		public void TriggerOnClickedRopeWithData(RopeRaycastData data)
		{
		}
	}
}
