using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class TransformCirclerShaker : MonoBehaviour
	{
		[SerializeField]
		private Transform shakePivot;

		[SerializeField]
		private FloatReference shakeRadius;

		[SerializeField]
		private FloatReference shakeSpeed;

		private float time;

		private void FixedUpdate()
		{
		}

		private void Shake()
		{
		}

		public void UpdateShakeSpeed(float speed)
		{
		}

		public void UpdateShakeRadius(float radius)
		{
		}
	}
}
