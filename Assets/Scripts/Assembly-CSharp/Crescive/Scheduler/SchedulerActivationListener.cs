using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Scheduler
{
	public class SchedulerActivationListener : MonoBehaviour
	{
		[SerializeField]
		private SchedulerSystem schedulerSystem;

		[SerializeField]
		private string scheduleItemId;

		public UnityEvent OnScheduleItemActive;

		public UnityEvent<string> OnScheduleActiveItemExpireDate;

		public UnityEvent OnScheduleItemExpired;

		public UnityEvent<bool> OnScheduleItemIsActive;

		public UnityEvent<bool> OnScheduleItemIsActiveReversed;

		public UnityEvent OnScheduleItemActivatedNow;

		public UnityEvent OnScheduleItemExpiredNow;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TriggerItemActivationEvents()
		{
		}

		private void OnScheduleActiveCallback(ScheduleActiveArgs args)
		{
		}

		private void OnScheduleExpiredCallback(ScheduleExpiredArgs args)
		{
		}

		private void OnScheduleActivatedNowCallback(ScheduleActiveArgs args)
		{
		}

		private void OnScheduleExpiredNowCallback(ScheduleExpiredNowArgs args)
		{
		}

		public void SetScheduleId(string id)
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
