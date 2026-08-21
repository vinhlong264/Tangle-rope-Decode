using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinsTapMoveChannelPinSlotListener : MonoBehaviour
	{
		[SerializeField]
		private PinSlotEntity pinSlotEntity;

		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		[SerializeField]
		private UnityEvent OnDroppableSlotTrue;

		[SerializeField]
		private UnityEvent OnNotDroppableSlotFalse;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnUpdateSelectedPinDroppableSlotsCallback(UpdateSelectedPinDroppableSlotsEventArgs args)
		{
		}
	}
}
