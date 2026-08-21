using BrunoMikoski.AnimationSequencer;
using Crescive.Cameras;
using Crescive.HelperTypes;
using Crescive.TransformUtils;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class MapShaker : MonoBehaviour
	{
		[SerializeField]
		private PinSlotsChannel slotsChannel;

		[SerializeField]
		private ClampsChannel clampsChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private RopesOptimizerChannel optimizerChannel;

		[SerializeField]
		private TransformChannel mapTransformChannel;

		[SerializeField]
		private CinemachineCameraOffsetChannel cameraOffsetChannel;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private CustomEase jumpEase;

		[SerializeField]
		private float totalRotateDuration;

		[SerializeField]
		private CustomEase totalRotateEase;

		[SerializeField]
		private float slotRotateDuration;

		[SerializeField]
		private CustomEase slotRotateEase;

		[SerializeField]
		private float cameraZoomOutDistance;

		[SerializeField]
		private float cameraAnimationDuration;

		[SerializeField]
		private CustomEase cameraAnimationEase;

		[SerializeField]
		private FloatVariableReference highTensionThreshold;

		[SerializeField]
		private float highTensionPhysicActivateDelay;

		public UnityEvent OnShuffleFinished;

		private Tween shakeTween;

		public void Shuffle()
		{
		}

		public void InstantShuffle()
		{
		}

		private Tween AnimateShuffle()
		{
			return null;
		}

		private Tween AnimateSlotsAndObjectsRotate()
		{
			return null;
		}

		private Tween AnimateCameraZoom()
		{
			return null;
		}

		private void SaveHighTensionRopes()
		{
		}
	}
}
