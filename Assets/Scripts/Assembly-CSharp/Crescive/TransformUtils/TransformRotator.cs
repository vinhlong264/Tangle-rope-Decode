using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class TransformRotator : MonoBehaviour
	{
		[SerializeField]
		private Transform rotatePivot;

		[SerializeField]
		public FloatReference rotateSpeed;

		[SerializeField]
		public Vector3 rotateAxis;

		private void FixedUpdate()
		{
		}

		private void Rotate()
		{
		}

		public void UpdateRotateSpeed(float speed)
		{
		}
	}
}
