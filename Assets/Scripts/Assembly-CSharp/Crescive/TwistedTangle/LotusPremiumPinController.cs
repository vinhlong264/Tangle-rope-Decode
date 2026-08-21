using Crescive.Factory;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LotusPremiumPinController : BasePinAnimationController
	{
		[SerializeField]
		private ParticleSystem trailParticles;

		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[SerializeField]
		private GameObjectFactory mergeFxFactory;

		[SerializeField]
		private GameObject lilyPad;

		[SerializeField]
		private float grabDuration;

		[SerializeField]
		private float dropDuration;

		[SerializeField]
		private float dropAnimationDelay;

		[SerializeField]
		private Vector2 blendMinMax;

		[SerializeField]
		private float overshoot;

		[SerializeField]
		private Vector2 overshootMinMax;

		[SerializeField]
		private float lilyPadGrabScale;

		[SerializeField]
		private float lilyPadDropScale;

		[SerializeField]
		private float idleDuration;

		[SerializeField]
		private float idleBlendOffset;

		private Color color;

		private Color maxColor;

		private void Awake()
		{
		}

		private void IdleAnimation()
		{
		}

		private float GetBlendShapeWeight()
		{
			return 0f;
		}

		private void SetBlendShapeWeight(float value)
		{
		}

		protected override void OnColorUpdatedInternal(Color newColor)
		{
		}

		protected override void OnGrabbedInternal()
		{
		}

		protected override void OnDroppedInternal()
		{
		}

		protected override void OnJumpAnimCompletedInternal()
		{
		}
	}
}
