using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class SchedulerData : ICloneable
	{
		public List<ScheduleData> Schedules;

		public SchedulerData(List<ScheduleData> schedules)
		{
		}

		public SchedulerData(SchedulerData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
