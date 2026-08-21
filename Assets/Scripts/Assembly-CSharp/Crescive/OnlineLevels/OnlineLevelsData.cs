using System;
using System.Collections.Generic;

namespace Crescive.OnlineLevels
{
	[Serializable]
	public class OnlineLevelsData : ICloneable
	{
		public List<OnlineLevelData> OnlineLevels;

		public OnlineLevelsData(OnlineLevelsData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
