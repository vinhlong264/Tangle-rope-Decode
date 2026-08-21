using System;

namespace Crescive.CreatorMode
{
	[Serializable]
	public struct GoldenRopeData : ICloneable
	{
		public int RopeIndex;

		public GoldenRopeData(int ropeIndex)
		{
			RopeIndex = 0;
		}

		public object Clone()
		{
			return null;
		}
	}
}
