using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class BattlePassScheduleSettings : ICloneable
	{
		public List<ScheduleGroup> ScheduleGroups;

		public List<string> SingleActivationGroups;

		public BattlePassScheduleSettings()
		{
		}

		public BattlePassScheduleSettings(BattlePassScheduleSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
