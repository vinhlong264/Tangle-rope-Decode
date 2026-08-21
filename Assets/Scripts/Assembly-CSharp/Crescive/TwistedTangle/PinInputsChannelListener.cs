using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinInputsChannelListener : MonoBehaviour
	{
		[SerializeField]
		private PinInputsChannel pinInputsChannel;

		[SerializeField]
		private UnityEvent<PinMoveEventArgs> OnMoveStarted;

		[SerializeField]
		private UnityEvent<PinMoveEventArgs> OnMoveEnded;

		[SerializeField]
		private UnityEvent<PinMoveEventArgs> OnMoveCanceled;

		[SerializeField]
		private UnityEvent<PinMoveEventArgs> OnMoveCompleted;

		[SerializeField]
		private UnityEvent<PinMoveSlotEventArgs> OnMoveToOtherSlot;

		[SerializeField]
		private UnityEvent<PinMoveSlotEventArgs> OnMoveToSameSlot;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
