using UnityEngine;

namespace Plinko
{
	public class Pusher : MonoBehaviour
	{
		[SerializeField]
		private Transform visual;

		[SerializeField]
		private float punchAnimationPower;

		[SerializeField]
		private float punchAnimationDuration;

		private PlinkoController plinkoController;

		private Vector3 visualDefaultScale;

		private void Awake()
		{
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		internal void Initialize(PlinkoController plinkoController)
		{
		}

		private void PushedAnimation()
		{
		}
	}
}
