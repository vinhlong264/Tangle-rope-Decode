using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeTension : MonoBehaviour
	{
		[SerializeField]
		private ObiRope rope;

		[SerializeField]
		private float minTension;

		[SerializeField]
		private float maxTension;

		public float Tension => 0f;

		public float TensionPercentage => 0f;
	}
}
