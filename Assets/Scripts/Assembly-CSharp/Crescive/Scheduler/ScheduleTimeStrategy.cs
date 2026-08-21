using System.ComponentModel;

namespace Crescive.Scheduler
{
	public enum ScheduleTimeStrategy
	{
		[Description("Weekly")]
		Weekly = 0,
		[Description("Date")]
		Date = 1,
		[Description("Monthly")]
		Monthly = 2
	}
}
