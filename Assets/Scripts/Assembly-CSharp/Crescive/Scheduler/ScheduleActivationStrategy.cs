using System.ComponentModel;

namespace Crescive.Scheduler
{
	public enum ScheduleActivationStrategy
	{
		[Description("OneByOne")]
		OneByOne = 0,
		[Description("All")]
		All = 1
	}
}
