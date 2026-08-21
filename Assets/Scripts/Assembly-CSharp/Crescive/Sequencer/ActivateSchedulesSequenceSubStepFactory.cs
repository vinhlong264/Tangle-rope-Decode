using System.Collections.Generic;
using Crescive.Scheduler;
using UnityEngine;

namespace Crescive.Sequencer
{
	[CreateAssetMenu(fileName = "Activate Schedules Sequence Sub Step Factory", menuName = "Crescive/Sequencer/Sub Step/Activate Schedules Sequence Sub Step Factory")]
	public class ActivateSchedulesSequenceSubStepFactory : SequenceSubStepFactory
	{
		[SerializeField]
		private SchedulerSystem schedulerSystem;

		public override List<SequenceSubStep> CreateSubSteps(SequenceStep sequenceStep)
		{
			return null;
		}
	}
}
