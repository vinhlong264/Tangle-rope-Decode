using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class MergePinsController : MonoBehaviour
	{
		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private float maxMergeDistance;

		[SerializeField]
		private float jumpDuration;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDragPin(DraggableDropEventParams arg0)
		{
		}

		private void OnDropPin(DraggableDropEventParams arg0)
		{
		}

		private void OnFindClosestPin(PinEntity pin, PinEntity closestPin)
		{
		}

		private void MergePins(PinEntity pin1, PinEntity pin2)
		{
		}

		private void DisablePin(PinEntity pin)
		{
		}

		private Tween MovePinToPin(PinEntity pin1, PinEntity pin2)
		{
			return null;
		}
	}
}
