using System;
using Crescive.TwistedTangle;

namespace Crescive.CreatorMode
{
	[Serializable]
	public struct KeyData : ICloneable
	{
		public int RopeIndex;

		public KeyData(int ropeIndex)
		{
			RopeIndex = 0;
		}

		public KeyData(KeyEntity keyEntity, RopesChannel ropesChannel)
		{
			RopeIndex = 0;
		}

		public object Clone()
		{
			return null;
		}
	}
}
