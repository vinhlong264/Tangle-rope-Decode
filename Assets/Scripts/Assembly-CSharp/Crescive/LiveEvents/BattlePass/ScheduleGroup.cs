using System;
using System.Collections.Generic;
using Crescive.Scheduler;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class ScheduleGroup : ICloneable
	{
		public string Id;

		public List<ScheduleData> Schedules;

		public ScheduleGroup()
		{
		}

		public ScheduleGroup(ScheduleGroup other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
