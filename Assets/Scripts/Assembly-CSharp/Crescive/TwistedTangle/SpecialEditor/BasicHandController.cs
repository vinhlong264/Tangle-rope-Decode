using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class BasicHandController : MonoBehaviour
	{
		[SerializeField]
		private Transform handTransform;

		[SerializeField]
		private float clickMinScale;

		[SerializeField]
		private float clickSpeed;

		private void Update()
		{
		}

		public void SetMinScale(float newMinScale)
		{
		}

		public void SetClickSpeed(float newSpeed)
		{
		}
	}
}
