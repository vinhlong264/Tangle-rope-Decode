using Crescive.Draggables;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinSlotCurrentDraggedPinFx : MonoBehaviour
	{
		[SerializeField]
		private PinSlotEntity pinSlotEntity;

		[SerializeField]
		private UnityEvent OnMoveStartedThisPin;

		[SerializeField]
		private UnityEvent OnMoveEndedThisPin;

		[SerializeField]
		private Draggable lastPinDraggable;

		public void OnMoveStarted(PinMoveEventArgs args)
		{
		}

		public void OnMoveEnded(PinMoveEventArgs args)
		{
		}
	}
}
