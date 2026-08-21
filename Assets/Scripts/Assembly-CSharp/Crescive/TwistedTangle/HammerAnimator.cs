using System.Collections.Generic;
using BrunoMikoski.AnimationSequencer;
using Crescive.TransformUtils;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class HammerAnimator : MonoBehaviour
	{
		[SerializeField]
		private HammerControllerChannel hammerControllerChannel;

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
		private TransformChannel cameraAnimationPivot;

		[SerializeField]
		private AudioSource hitAudio;

		[SerializeField]
		private Transform moveTransform;

		[SerializeField]
		private Transform pathPivot;

		[SerializeField]
		private bool drawPaths;

		[SerializeField]
		private Transform startPosition;

		[SerializeField]
		private Transform startPositionOffset;

		[SerializeField]
		private List<Transform> comeInOutPath;

		[SerializeField]
		private List<Transform> hitPath;

		[SerializeField]
		private CustomEase comeInEase;

		[SerializeField]
		private CustomEase comeOutEase;

		[SerializeField]
		private Transform rotateTransform;

		[SerializeField]
		private Transform startRotation;

		[SerializeField]
		private Transform aboutToHitRotation;

		[SerializeField]
		private Transform hitRotation;

		[SerializeField]
		private Transform scaleTransform;

		[SerializeField]
		private float startDelay;

		public UnityEvent OnHit;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private static bool IsValidPoint(Transform point)
		{
			return false;
		}

		private static Vector3 GetPointPos(Transform point)
		{
			return default(Vector3);
		}

		private void PlayAnimation(Vector3 hitPosition)
		{
		}

		private void InitializeAnimation(Vector3 hitPosition)
		{
		}

		private void MoveAnimation()
		{
		}

		private void RotateAnimation()
		{
		}

		private void HitAnimation()
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

		private void OnPinChosenCallback(PinEntity pin)
		{
		}

		public void CancelAnimation()
		{
		}

		private void PlayAnimationAtCurrentPosition()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private static void DrawPathPoints(IEnumerable<Transform> pathPoints)
		{
		}
	}
}
