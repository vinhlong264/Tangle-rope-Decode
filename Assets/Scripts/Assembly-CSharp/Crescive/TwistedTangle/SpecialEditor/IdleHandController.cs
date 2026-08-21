using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class IdleHandController : MonoBehaviour
	{
		[SerializeField]
		private Transform handTransform;

		[SerializeField]
		private float clickMinScale;

		[SerializeField]
		private float clickSpeed;

		[SerializeField]
		private float minXLimitIdle;

		[SerializeField]
		private float maxXLimitIdle;

		[SerializeField]
		private float minYLimitIdle;

		[SerializeField]
		private float maxYLimitIdle;

		[SerializeField]
		private float speedIdle;

		private Tweener scaleTweener;

		private Tweener idleMovementTween;

		private bool inputIsDown;

		private Vector3 randomTargetPosition;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void SetMovement()
		{
		}

		private void DownClick()
		{
		}

		private void MoveThenClick()
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

		private void SetNewTargetPosition()
		{
		}

		private void MoveToTarget()
		{
		}

		private void OnMoveComplete()
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
