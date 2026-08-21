using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleActivatedNowArgs : ScheduleActiveArgs
	{
		public ScheduleActivatedNowArgs(ScheduleData scheduleData, List<string> activeItemIds)
			: base(null, null)
		{
		}
	}
}
