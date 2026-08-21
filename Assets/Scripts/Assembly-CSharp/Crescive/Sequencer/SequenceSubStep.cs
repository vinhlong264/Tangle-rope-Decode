using System;

namespace Crescive.Sequencer
{
	[Serializable]
	public class SequenceSubStep
	{
		public SequenceStep SequenceStep;

		public string Id;

		public bool isStarted;

		public bool isFinished;

		public SequenceSubStep(SequenceStep sequenceStep, string id)
		{
		}
	}
}
