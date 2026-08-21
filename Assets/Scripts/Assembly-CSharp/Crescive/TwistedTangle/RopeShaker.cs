using Crescive.HelperTypes;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeShaker : MonoBehaviour
	{
		[SerializeField]
		private RopeEntity ropeEntity;

		[SerializeField]
		private BoolVariableReference shakeEnabled;

		[SerializeField]
		private FloatVariableReference minShakeForce;

		[SerializeField]
		private FloatVariableReference maxShakeForce;

		private ObiRope Rope => null;

		private RopePhysicToggler PhysicToggler => null;

		private void FixedUpdate()
		{
		}

		private void ShakeRope()
		{
		}
	}
}
