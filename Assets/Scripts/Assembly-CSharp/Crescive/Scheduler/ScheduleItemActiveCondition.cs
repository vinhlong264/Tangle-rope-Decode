using UnityAtoms;
using UnityEngine;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(fileName = "Schedule Item Active Condition", menuName = "Crescive/Scheduler/Condition/Schedule Item Active Condition")]
	public class ScheduleItemActiveCondition : AtomCondition
	{
		[SerializeField]
		private SchedulerSystem schedulerSystem;

		[SerializeField]
		private string scheduleItemId;

		public override bool Call()
		{
			return false;
		}
	}
}
