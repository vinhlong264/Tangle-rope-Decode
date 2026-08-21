using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(fileName = "Scheduler Events", menuName = "Crescive/Scheduler/Event/Scheduler Events")]
	public class SchedulerEvents : ScriptableObject
	{
		public UnityEvent<ScheduleActiveArgs> OnScheduleActive;

		public UnityEvent<ScheduleActivatedNowArgs> OnScheduleActivatedNow;

		public UnityEvent<ScheduleExpiredArgs> OnScheduleExpired;

		public UnityEvent<ScheduleExpiredNowArgs> OnScheduleExpiredNow;

		public void TriggerScheduleActive(ScheduleData scheduleData, List<string> activeItemIds)
		{
		}

		public void TriggerScheduleActivatedNow(ScheduleData scheduleData, List<string> activeItemIds)
		{
		}

		public void TriggerScheduleExpired(ScheduleData scheduleData)
		{
		}

		public void TriggerScheduleExpiredNow(ScheduleData scheduleData, List<string> expiredItemIds)
		{
		}
	}
}
