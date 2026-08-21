using System.Collections.Generic;
using Crescive.TransformUtils;
using Crescive.Utils;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PocketWatchAnimator : MonoBehaviour
	{
		[SerializeField]
		private PocketWatchAnimatorCanvasPanelChannel canvasPanelChannel;

		[SerializeField]
		private GameObject model;

		[SerializeField]
		private List<TrailRenderer> trails;

		[SerializeField]
		private List<ParticleSystem> particles;

		[SerializeField]
		private TransformChannel cameraAnimationPivot;

		[SerializeField]
		private AudioSource increaseTimeAudio;

		[SerializeField]
		private AudioSource increaseTimeFinishedAudio;

		[SerializeField]
		private IntVariable pocketWatchExtraTime;

		[SerializeField]
		private IntVariable timeLimitTextValue;

		[SerializeField]
		private BaseDesyncVariable timeLimitDesync;

		[SerializeField]
		private Transform moveTransform;

		[SerializeField]
		private Transform pointsTransform;

		[SerializeField]
		private bool drawPaths;

		[SerializeField]
		private List<Transform> comeInPoints;

		[SerializeField]
		private List<Transform> comeOutPoints;

		[SerializeField]
		private Transform scaleTransform;

		[SerializeField]
		private Transform rotateTransform;

		[SerializeField]
		private Transform hourPivot;

		[SerializeField]
		private Transform minutePivot;

		[SerializeField]
		private Transform crownPivot;

		[SerializeField]
		private Transform startRotation;

		[SerializeField]
		private Transform minuteHandStartRotation;

		[SerializeField]
		private Transform hourHandStartRotation;

		[SerializeField]
		private float startDelay;

		[SerializeField]
		private float comeInOutDuration;

		[SerializeField]
		private float increaseTimeDuration;

		[SerializeField]
		private float comeOutDelay;

		[SerializeField]
		private int minutePivotFullRotateCount;

		[SerializeField]
		private float hourHandRotationOffset;

		[SerializeField]
		private float minuteHandRotationOffset;

		[SerializeField]
		private float timeTextScale;

		public UnityEvent OnClockHandsRotated;

		private static Vector3 GetPointPos(Transform point)
		{
			return default(Vector3);
		}

		private void InitializeAnimation()
		{
		}

		private void MoveAnimation()
		{
		}

		private void RotateAnimation()
		{
		}

		private void ScaleAnimation()
		{
		}

		private void CanvasAnimation()
		{
		}

		private void VariableAnimation()
		{
		}

		private void SetTimeTextAmount(int value)
		{
		}

		private int GetTimeTextAmount()
		{
			return 0;
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

		public void PlayAnimation()
		{
		}

		public void CancelAnimation()
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
