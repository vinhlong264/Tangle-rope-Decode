using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	public class InGameOfferAmountAnimator : MonoBehaviour
	{
		[SerializeField]
		private InGameOfferController controller;

		[SerializeField]
		[Space]
		private float animateDelay;

		public UnityEvent OnAnimationStarted;

		public UnityEvent OnAnimationEnded;

		public UnityEvent OnAnimationReset;

		private void Awake()
		{
		}

		public void Animate()
		{
		}

		public void ResetAnimation()
		{
		}
	}
}
