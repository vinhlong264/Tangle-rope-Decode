using System.Collections.Generic;
using Crescive.Channels;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Sequencer
{
	[CreateAssetMenu(fileName = "Sequencer Channel", menuName = "Crescive/Sequencer/Data/Sequencer Channel")]
	public class SequencerChannel : ObjectChannel<Sequencer>
	{
		[Header("Data")]
		[SerializeField]
		private List<SequenceStep> steps;

		[CanBeNull]
		private SequenceStep ActiveSequenceStep => null;

		public UnityEvent OnSequenceStarted => null;

		public UnityEvent OnSequenceFinished => null;

		public UnityEvent OnSequenceCanceled => null;

		public UnityEvent OnSequenceFinishedOrCanceled => null;

		public List<SequenceStep> Steps => null;

		public bool IsSequencePlaying()
		{
			return false;
		}
	}
}
