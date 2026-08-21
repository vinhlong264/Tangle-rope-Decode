using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopePhysicToggler : MonoBehaviour
	{
		[field: SerializeField]
		public RopeEntity Rope { get; private set; }

		public bool IsActive => false;

		public float Timer { get; private set; }

		public void SetPhysicsActive(bool active)
		{
		}

		public void SetTimer(float timer)
		{
		}

		public bool HasTimeOut(float resetPeriod)
		{
			return false;
		}
	}
}
