using System;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleExpiredArgs
	{
		public ScheduleData ScheduleData;

		public ScheduleExpiredArgs(ScheduleData scheduleData)
		{
		}
	}
}
