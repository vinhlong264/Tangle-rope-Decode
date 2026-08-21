using UnityAtoms;
using UnityEngine;

namespace Crescive.Sequencer
{
	[CreateAssetMenu(fileName = "Sequence Step State Condition", menuName = "Crescive/Sequencer/Condition/Sequence Step State Condition")]
	public class SequenceStepStateCondition : AtomCondition
	{
		[SerializeField]
		private SequenceStep sequenceStep;

		[SerializeField]
		private bool isStarted;

		[SerializeField]
		private bool isFinished;

		public override bool Call()
		{
			return false;
		}
	}
}
