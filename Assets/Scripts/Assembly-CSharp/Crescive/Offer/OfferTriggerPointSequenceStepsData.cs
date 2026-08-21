using System.Collections.Generic;
using Crescive.Sequencer;
using UnityEngine;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Offer Trigger Point Sequence Steps Data", menuName = "Crescive/Offer/Offer Trigger Point Sequence Steps Data")]
	public class OfferTriggerPointSequenceStepsData : ScriptableObject
	{
		[SerializeField]
		private List<TriggerPointSequenceStep> data;

		public List<TriggerPointSequenceStep> Data => null;

		public TriggerPointSequenceStep GetValue(SequenceStep step)
		{
			return null;
		}

		public TriggerPointSequenceStep GetValue(string triggerPoint)
		{
			return null;
		}
	}
}
