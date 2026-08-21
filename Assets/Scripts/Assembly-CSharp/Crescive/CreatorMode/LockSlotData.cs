using System;

namespace Crescive.CreatorMode
{
	[Serializable]
	public struct LockSlotData : ICloneable
	{
		public int Index;

		public LockSlotData(int index)
		{
			Index = 0;
		}

		public object Clone()
		{
			return null;
		}
	}
}
