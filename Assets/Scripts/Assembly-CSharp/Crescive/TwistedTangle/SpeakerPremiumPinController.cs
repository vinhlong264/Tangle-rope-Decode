using Crescive.Factory;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class SpeakerPremiumPinController : BasePinAnimationController
	{
		[SerializeField]
		private ParticleSystem trailParticles;

		[SerializeField]
		private ParticleSystem speakerBoomParticles;

		[SerializeField]
		private ParticleSystem angrySpeakerBoomParticles;

		[SerializeField]
		private GameObject speakerInside;

		[SerializeField]
		private GameObjectFactory mergeFxFactory;

		[SerializeField]
		private float angryPunchScale;

		[SerializeField]
		private float angryPunchInterval;

		[SerializeField]
		private Vector2 punchMinMax;

		[SerializeField]
		private Vector2 intervalMinMax;

		private Color color;

		private Color maxColor;

		private void Awake()
		{
		}

		private void IdleAnimation()
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
