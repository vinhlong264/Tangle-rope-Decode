using Crescive.Draggables;
using Crescive.Factory;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class SportsShoePremiumPinController : BasePinAnimationController, IDropTargetHolderPlacedListener, IDropTargetHolderHoldPlacedListener
	{
		[SerializeField]
		private ParticleSystem trailParticles;

		[SerializeField]
		private GameObjectFactory stepDustFactory;

		[SerializeField]
		private GameObjectFactory mergeFxFactory;

		[SerializeField]
		private Transform shoePivot;

		[SerializeField]
		private float rotateDuration;

		[SerializeField]
		private float landDuration;

		[SerializeField]
		private float heelRotate;

		[SerializeField]
		private Vector2 sideRotateMinMax;

		[SerializeField]
		private float rotateOvershoot;

		[SerializeField]
		private float idleRotateDuration;

		[SerializeField]
		private float idleHeelRotate;

		[SerializeField]
		private Vector2 idleIntervalMinMax;

		[SerializeField]
		private Vector2Int idleRotateAmountMinMax;

		private Color color;

		private Color maxColor;

		private void Awake()
		{
		}

		private void PlayFxWithColor(GameObjectFactory fxFactory)
		{
		}

		private void IdleAnimation()
		{
		}

		private void DropAnimation()
		{
		}

		private void PlacedAnimation()
		{
		}

		protected override void OnColorUpdatedInternal(Color newColor)
		{
		}

		protected override void OnDroppedInternal()
		{
		}

		protected override void OnJumpAnimCompletedInternal()
		{
		}

		public void OnDropTargetHolderPlaced(DropTarget dropTarget)
		{
		}

		public void OnDropTargetHolderHoldPlaced(DropTarget dropTarget)
		{
		}
	}
}
