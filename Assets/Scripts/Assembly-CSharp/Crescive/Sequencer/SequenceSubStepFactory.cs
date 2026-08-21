using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Sequencer
{
	public abstract class SequenceSubStepFactory : ScriptableObject
	{
		public abstract List<SequenceSubStep> CreateSubSteps(SequenceStep sequenceStep);
	}
}
