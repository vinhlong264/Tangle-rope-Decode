using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class HammerControllerChannelListener : MonoBehaviour
	{
		[SerializeField]
		private HammerControllerChannel hammerControllerChannel;

		public UnityEvent<PinEntity> OnPinChosen;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
