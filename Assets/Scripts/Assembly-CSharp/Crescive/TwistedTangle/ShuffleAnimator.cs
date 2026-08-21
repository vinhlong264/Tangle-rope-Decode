using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class ShuffleAnimator : MonoBehaviour
	{
		[SerializeField]
		private GameObject model;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private float actionDelay;

		public UnityEvent OnShuffle;

		public void PlayAnimation()
		{
		}

		public void CancelAnimation()
		{
		}
	}
}
