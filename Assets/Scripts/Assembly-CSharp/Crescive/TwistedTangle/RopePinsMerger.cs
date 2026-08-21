using DG.Tweening;
using Obi;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopePinsMerger : MonoBehaviour
	{
		[SerializeField]
		private RopeEntity ropeEntity;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private float jumpPower;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private float jumpTargetOffset;

		[SerializeField]
		private Ease jumpEase;

		[SerializeField]
		private Vector3 punchScale;

		[SerializeField]
		private float punchDuration;

		[SerializeField]
		private float destroyScaleDuration;

		public UnityEvent OnMergeStarted;

		public UnityEvent<Vector3> OnJumpAnimCompleted;

		public UnityEvent<RopeEntity> OnMergeCompleted;

		public bool IsMergeStarted { get; private set; }

		public bool IsMerging { get; private set; }

		public bool IsMerged { get; private set; }

		public bool AllowOnlyForceMerge { get; private set; }

		private Tween AnimateJump(PinEntity sourcePin, PinEntity targetPin, bool animateTarget)
		{
			return null;
		}

		private Tween AnimateOneSideMerge(PinEntity targetPin, bool animateTarget)
		{
			return null;
		}

		private Tween AnimateChangeRopeLength(RopeEntity entity, float newLength, float duration)
		{
			return null;
		}

		private void DestroyRopeAndPins()
		{
		}

		private void TryRemovePinFromHolder(PinEntity pin)
		{
		}

		private void TryRemovePinsFromHolder()
		{
		}

		private void DisableRopePinsDraggables()
		{
		}

		private void DisableRopePinsDraggables(bool force, params PinEntity[] pins)
		{
		}

		private PinEntity GetSourcePin()
		{
			return null;
		}

		private PinEntity GetTargetPin()
		{
			return null;
		}

		private void DisableConnectedRopesCollisions()
		{
		}

		private void DisableConnectedRopesPinDraggables(bool force = false)
		{
		}

		private void MergeConnectedRopes()
		{
		}

		private void PerformMergeStarted(params PinEntity[] pins)
		{
		}

		private void PerformJumpAnimCompleted(Vector3 jumpPosition, params PinEntity[] pins)
		{
		}

		private void PerformMergeCompleted(params PinEntity[] pins)
		{
		}

		private void TriggerPinMergeStartedDelegations(params PinEntity[] pins)
		{
		}

		private void TriggerPinJumpAnimCompletedDelegations(params PinEntity[] pins)
		{
		}

		private void TriggerPinMergeCompletedDelegations(params PinEntity[] pins)
		{
		}

		public bool CanMerge(bool checkBothPins = true, bool checkConnectedRopes = true)
		{
			return false;
		}

		public void Merge(bool forceSelfMerge = false)
		{
		}

		public void Merge(PinEntity sourcePin, PinEntity targetPin, bool forceSelfMerge = false)
		{
		}

		public void TryOneSideMerge()
		{
		}

		public void SetAllowOnlyForceMerge(bool value)
		{
		}
	}
}
