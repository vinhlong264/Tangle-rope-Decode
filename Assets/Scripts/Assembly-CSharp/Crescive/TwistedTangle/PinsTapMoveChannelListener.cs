using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinsTapMoveChannelListener : MonoBehaviour
	{
		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		[SerializeField]
		private UnityEvent<PinEntityEventArgs> OnSelectPin;

		[SerializeField]
		private UnityEvent<PinEntityEventArgs> OnDeselectPinWithoutGrab;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSelectPinCallback(PinEntityEventArgs args)
		{
		}

		private void OnDeselectPinWithoutGrabCallback(PinEntityEventArgs args)
		{
		}
	}
}
