using System;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleExpirationData
	{
		public ScheduleData ScheduleData;

		public string Reason;

		public ScheduleExpirationData(ScheduleData scheduleData, string reason)
		{
		}
	}
}
