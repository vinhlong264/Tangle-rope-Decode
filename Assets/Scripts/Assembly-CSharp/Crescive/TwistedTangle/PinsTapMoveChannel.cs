using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "PinsTapMoveChannel", menuName = "GameData/Channel/PinsTapMoveChannel")]
	public class PinsTapMoveChannel : ScriptableObject
	{
		public UnityEvent<PinEntityEventArgs> OnSelectPin;

		public UnityEvent<PinEntityEventArgs> OnDeselectPinWithoutGrab;

		public UnityEvent<PinEntityEventArgs> OnDeselectPinAtSelect;

		public UnityEvent<PinEntityEventArgs> OnPinTapMoveCanceled;

		public UnityEvent<UpdateSelectedPinDroppableSlotsEventArgs> OnUpdateSelectedPinDroppableSlots;

		[field: SerializeField]
		public PinEntity SelectedPin { get; set; }

		[field: SerializeField]
		public List<PinSlotEntity> SelectedPinDroppableSlots { get; private set; }

		[field: SerializeField]
		public List<PinSlotEntity> CurrentDestinationPinSlots { get; private set; }

		public void ResetData()
		{
		}
	}
}
