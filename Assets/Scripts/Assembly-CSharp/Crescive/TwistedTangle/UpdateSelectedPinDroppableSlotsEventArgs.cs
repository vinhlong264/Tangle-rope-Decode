using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class UpdateSelectedPinDroppableSlotsEventArgs
	{
		public List<PinSlotEntity> SelectedPinDroppableSlots;

		public UpdateSelectedPinDroppableSlotsEventArgs(List<PinSlotEntity> selectedPinDroppableSlots)
		{
		}
	}
}
