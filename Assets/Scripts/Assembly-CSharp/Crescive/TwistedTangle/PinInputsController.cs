using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinInputsController : MonoBehaviour
	{
		[SerializeField]
		private PinInputsChannel pinInputsChannel;

		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TriggerMoveStarted(PinEntity pinEntity)
		{
		}

		private void TriggerMoveCompleted(PinEntity pinEntity)
		{
		}

		private void TriggerMoveCanceled(PinEntity pinEntity)
		{
		}

		private void OnSelectPinCallback(PinEntityEventArgs args)
		{
		}

		private void OnDeselectPinAtSelect(PinEntityEventArgs args)
		{
		}

		private void OnPinTapMoveCanceledCallback(PinEntityEventArgs args)
		{
		}

		private void OnGrabCallback(DraggableEventParams args)
		{
		}

		private void OnDropCallback(DraggableDropEventParams args)
		{
		}
	}
}
