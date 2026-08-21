using System;

namespace Crescive.Scheduler
{
	[Serializable]
	public class ScheduleSaveData : ICloneable
	{
		public string Id;

		public bool IsStarted;

		public bool IsActive;

		public int ActivationCount;

		public string ActivationDate;

		public string TimeStrategy;

		public int RevisionNumber;

		public ScheduleSaveData(string id, bool isStarted, bool isActive, int activationCount, string activationDate, string timeStrategy, int revisionNumber)
		{
		}

		public ScheduleSaveData(ScheduleSaveData other)
		{
		}

		public ScheduleSaveData(ScheduleData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
