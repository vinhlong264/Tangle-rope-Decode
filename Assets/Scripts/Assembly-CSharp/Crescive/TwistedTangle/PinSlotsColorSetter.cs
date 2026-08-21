using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinSlotsColorSetter : MonoBehaviour
	{
		[field: SerializeField]
		public PinSlotsChannel PinSlotsChannel { get; private set; }

		public void ChangePinColor(PinSlotEntity pinSlotEntity, PinSlotColorsData colorsData)
		{
		}

		public void ChangeAllPinColors(PinSlotColorsData colorsData)
		{
		}

		public void ChangeAllPinSlotColors(Color color)
		{
		}
	}
}
