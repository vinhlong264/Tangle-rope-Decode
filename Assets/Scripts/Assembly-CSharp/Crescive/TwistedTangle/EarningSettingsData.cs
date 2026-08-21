using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class EarningSettingsData : ICloneable
	{
		public int EarningByRemainingMove;

		public List<DifficultyEarningData> DifficultyEarnings;

		public EarningSettingsData(List<DifficultyEarningData> difficultyEarnings, int earningByRemainingMove)
		{
		}

		public EarningSettingsData(EarningSettingsData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
