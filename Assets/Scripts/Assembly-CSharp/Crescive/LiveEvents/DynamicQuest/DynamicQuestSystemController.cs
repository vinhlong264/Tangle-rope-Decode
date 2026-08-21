using System.Collections.Generic;
using Crescive.Scheduler;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[DefaultExecutionOrder(-10000000)]
	public class DynamicQuestSystemController : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private SchedulerSystem schedulerSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private bool TryGetQuestId(List<string> ids, out string id)
		{
			id = null;
			return false;
		}

		private void OnScheduleActivatedNow(ScheduleActivatedNowArgs args)
		{
		}

		private void OnScheduleExpiredNow(ScheduleExpiredNowArgs args)
		{
		}
	}
}
