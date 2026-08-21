using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleExpiredNowArgs : ScheduleExpiredArgs
	{
		public List<string> ExpiredItemIds;

		public ScheduleExpiredNowArgs(ScheduleData scheduleData, List<string> expiredItemIds)
			: base(null)
		{
		}
	}
}
