using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class KeyEntity : MonoBehaviour
	{
		[SerializeField]
		private ObiParticleAttacher particleAttacher;

		[SerializeField]
		private ClampsChannel clampsChannel;

		[SerializeField]
		private Transform chain;

		[SerializeField]
		private Transform key;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private Ease jumpEase;

		[SerializeField]
		private float destroyDuration;

		[SerializeField]
		private float punchScale;

		[SerializeField]
		private float punchScaleDuration;

		[SerializeField]
		private float jumpPositionYOffset;

		public UnityEvent<RopeEntity> OnAttachedToRope;

		public UnityEvent<RopeEntity> OnDetachedFromRope;

		public UnityEvent<RopeEntity> OnRopeMergeStarted;

		public RopeEntity AttachedRope { get; private set; }

		public bool HasAttachedRope => false;

		public void AttachToRope(RopeEntity ropeEntity)
		{
		}

		public void SetParticleAttacherEnable(bool enabled)
		{
		}

		public void DetachFromRope()
		{
		}

		private void RopeMergeStartedCallback()
		{
		}

		private void DestroyChain()
		{
		}

		private void UnlockClamps()
		{
		}

		private void DestroySelf()
		{
		}

		private Tween PunchScaleKey()
		{
			return null;
		}

		private Tween JumpToClamp(ClampEntity clamp)
		{
			return null;
		}
	}
}
