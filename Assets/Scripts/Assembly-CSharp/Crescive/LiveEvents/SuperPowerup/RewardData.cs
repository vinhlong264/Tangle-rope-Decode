using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.SuperPowerup
{
	[Serializable]
	public class RewardData : ICloneable
	{
		public List<string> CurrentPowerUpIds;

		public RewardData()
		{
		}

		public RewardData(RewardData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
