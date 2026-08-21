using System;
using System.Collections.Generic;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleData : ICloneable
	{
		public bool Enabled;

		public string Id;

		public string TimeStrategy;

		public int RevisionNumber;

		public float StartTime;

		public float EndTime;

		public string StartDate;

		public string EndDate;

		public string ActivationStrategy;

		public int MinLevel;

		public List<string> ItemIds;

		public ScheduleTimeStrategy TimeStrategyEnum => default(ScheduleTimeStrategy);

		public ScheduleActivationStrategy ActivationStrategyEnum => default(ScheduleActivationStrategy);

		public ScheduleData(bool enabled, string id, string timeStrategy, int revisionNumber, float startTime, float endTime, string startDate, string endDate, string activationStrategy, int minLevel, List<string> itemIds)
		{
		}

		public ScheduleData(ScheduleData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
