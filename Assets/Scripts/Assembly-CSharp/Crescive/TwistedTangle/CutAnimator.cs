using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class CutAnimator : MonoBehaviour
	{
		[SerializeField]
		private RopeRaycasterChannel ropeRaycasterChannel;

		[SerializeField]
		private GameObject model;

		[SerializeField]
		private Transform flipTransform;

		[SerializeField]
		private List<TrailRenderer> trails;

		[SerializeField]
		private List<ParticleSystem> particles;

		[SerializeField]
		private ParticleSystem cutParticle;

		[SerializeField]
		private Transform moveTransform;

		[SerializeField]
		private Transform cutPointEnd;

		[SerializeField]
		private List<Transform> pathPoints;

		[SerializeField]
		private bool drawPath;

		[SerializeField]
		private Transform rightBlade;

		[SerializeField]
		private Transform leftBlade;

		[SerializeField]
		private float rotateAmount;

		[SerializeField]
		private Transform scaleTransform;

		private Quaternion rightBladeOriginalRotation;

		private Quaternion leftBladeOriginalRotation;

		public UnityEvent OnCut;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PlayAnimation(Vector3 cutPosition, Vector3 cutRotationVector)
		{
		}

		private void InitializeAnimation(Vector3 cutPosition, Vector3 cutRotationVector)
		{
		}

		private void MoveAnimation()
		{
		}

		private void CutAnimation()
		{
		}

		private void ScaleAnimation()
		{
		}

		private void StartFx()
		{
		}

		private void StopFx()
		{
		}

		private void ClearFx()
		{
		}

		private void OnClickedRopeWithDataCallback(RopeRaycastData data)
		{
		}

		public void CancelAnimation()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
