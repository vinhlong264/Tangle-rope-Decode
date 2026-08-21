using System;
using Crescive.Sequencer;
using UnityAtoms.BaseAtoms;

namespace Crescive.Offer
{
	[Serializable]
	public class TriggerPointSequenceStep
	{
		public StringConstant TriggerPoint;

		public SequenceStep SequenceStep;
	}
}
