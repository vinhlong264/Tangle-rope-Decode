using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleActiveArgs
	{
		public ScheduleData ScheduleData;

		public List<string> ActiveItemIds;

		public ScheduleActiveArgs(ScheduleData scheduleData, List<string> activeItemIds)
		{
		}
	}
}
