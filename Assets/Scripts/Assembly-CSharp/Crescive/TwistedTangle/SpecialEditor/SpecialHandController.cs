using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SpecialHandController : MonoBehaviour
	{
		[SerializeField]
		private Transform handTransform;

		[SerializeField]
		private float clickMinScale;

		[SerializeField]
		private float clickSpeed;

		private Tweener scaleTweener;

		private bool inputIsDown;

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void SetMovement()
		{
		}

		private void DownClick()
		{
		}

		private void UpClick()
		{
		}

		private void DownBehaviour()
		{
		}

		private void UpBehaviour()
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
