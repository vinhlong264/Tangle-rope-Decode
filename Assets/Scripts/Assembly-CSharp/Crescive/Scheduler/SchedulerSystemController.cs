using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Scheduler
{
	[DefaultExecutionOrder(-9990)]
	public class SchedulerSystemController : MonoBehaviour
	{
		[SerializeField]
		private SchedulerSystem schedulerSystem;

		public UnityEvent OnRefreshSchedulesFinished;

		private void Awake()
		{
		}

		private void SyncData()
		{
		}

		private void StartSchedulesIfExist()
		{
		}

		private void ExpireSchedulesIfExist()
		{
		}

		private void ExpireSchedules(List<ScheduleExpirationData> scheduleExpirationsData)
		{
		}

		public void RefreshSchedules()
		{
		}
	}
}
