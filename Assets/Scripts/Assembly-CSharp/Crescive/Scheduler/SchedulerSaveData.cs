using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class SchedulerSaveData : ICloneable
	{
		public List<ScheduleSaveData> Schedules;

		public SchedulerSaveData(List<ScheduleSaveData> schedules)
		{
		}

		public SchedulerSaveData(SchedulerSaveData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
