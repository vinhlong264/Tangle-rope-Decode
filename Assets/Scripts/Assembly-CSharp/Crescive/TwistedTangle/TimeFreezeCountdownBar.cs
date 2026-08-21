using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(10)]
	public class TimeFreezeCountdownBar : MonoBehaviour
	{
		[SerializeField]
		private TimeFreezeAnimatorChannel timeFreezeAnimatorChannel;

		[SerializeField]
		private Slider countdownSlider;

		public Slider CountdownSlider => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
