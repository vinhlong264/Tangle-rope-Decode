using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	public static class ScheduleDataExtensions
	{
		public static bool IsInSchedule(this ScheduleData scheduleData, SchedulerSystem system)
		{
			return false;
		}

		public static bool IsOutOfSchedule(this ScheduleData scheduleData, SchedulerSystem system)
		{
			return false;
		}

		public static void GetStartEndTimeDates(this ScheduleData scheduleData, SchedulerSystem system, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public static float GetExpireSeconds(this ScheduleData scheduleData, SchedulerSystem system)
		{
			return 0f;
		}

		public static List<string> GetActiveItemIds(this ScheduleData scheduleData, SchedulerSystem system)
		{
			return null;
		}
	}
}
