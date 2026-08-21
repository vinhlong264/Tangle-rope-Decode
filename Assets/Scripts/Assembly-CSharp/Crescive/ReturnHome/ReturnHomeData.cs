using System;

namespace Crescive.ReturnHome
{
	[Serializable]
	public class ReturnHomeData : ICloneable
	{
		public bool Enabled;

		public int MinLevel;

		public int LevelFrequency;

		public ReturnHomeData(ReturnHomeData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
