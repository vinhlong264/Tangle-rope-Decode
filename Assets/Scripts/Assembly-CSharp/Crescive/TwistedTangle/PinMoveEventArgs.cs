using System;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class PinMoveEventArgs
	{
		public PinEntity PinEntity;

		public PinMoveEventArgs(PinEntity pinEntity)
		{
		}
	}
}
