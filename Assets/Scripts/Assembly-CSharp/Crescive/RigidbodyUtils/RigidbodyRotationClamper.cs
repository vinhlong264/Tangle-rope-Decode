using UnityEngine;

namespace Crescive.RigidbodyUtils
{
	public class RigidbodyRotationClamper : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody body;

		[SerializeField]
		private Vector2 minMaxZRot;

		[SerializeField]
		private float rotateSpeed;

		private void FixedUpdate()
		{
		}

		private void ClampRotation()
		{
		}
	}
}
