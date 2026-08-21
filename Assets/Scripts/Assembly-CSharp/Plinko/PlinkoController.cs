using UnityEngine;

namespace Plinko
{
	public class PlinkoController : MonoBehaviour
	{
		public static PlinkoController Instance;

		public float MinStartForce;

		public float MaxStartForce;

		public float ObstaclePushPlusPower;

		public float PusherPushPlusPower;

		public float BallBounciness;

		public float BallFriction;

		public float MinStartOffset;

		public float MaxStartOffset;

		public float BallMaxVelocityMagnitude;

		public float BallGravityScale;

		[SerializeField]
		private Pusher[] pushers;

		[SerializeField]
		private Obstacle[] obstacles;

		[SerializeField]
		private Spawner spawner;

		[SerializeField]
		private PhysicsMaterial2D physicsMaterial2D;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
