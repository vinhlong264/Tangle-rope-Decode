using System.Collections.Generic;

namespace Crescive.Scheduler
{
	public interface ISchedulerSystemDataProvider
	{
		List<ScheduleData> GetSchedules();
	}
}
