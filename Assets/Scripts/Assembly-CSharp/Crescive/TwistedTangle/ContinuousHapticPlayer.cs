using Crescive.Vibrations;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class ContinuousHapticPlayer : MonoBehaviour
	{
		[SerializeField]
		private HapticChannel hapticChannel;

		[SerializeField]
		private float continuousAmplitude;

		[SerializeField]
		private float continuousFrequency;

		public void PlayContinuousHaptic(float duration)
		{
		}
	}
}
