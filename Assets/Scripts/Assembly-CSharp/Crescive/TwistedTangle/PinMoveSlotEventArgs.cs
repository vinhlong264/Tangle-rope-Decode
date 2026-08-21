using System;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class PinMoveSlotEventArgs
	{
		public PinEntity PinEntity;

		public PinSlotEntity PinSlotEntity;

		public PinMoveSlotEventArgs(PinEntity pinEntity, PinSlotEntity pinSlotEntity)
		{
		}
	}
}
