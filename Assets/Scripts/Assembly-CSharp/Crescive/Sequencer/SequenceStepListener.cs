using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Sequencer
{
	public class SequenceStepListener : MonoBehaviour
	{
		[SerializeField]
		private SequenceStep sequenceStep;

		public UnityEvent OnStepStarted;

		public UnityEvent OnStepEnded;

		public UnityEvent OnStepChanged;

		public UnityEvent<SequenceSubStep> OnSubStepStarted;

		public UnityEvent<string> OnSubStepStartedId;

		private bool StepUsesSubSteps => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnStepStartedCallback(SequenceStep _)
		{
		}

		private void OnStepEndedCallback(SequenceStep _)
		{
		}

		private void OnStepChangedCallback(SequenceStep _)
		{
		}

		private void OnSubStepStartedCallback(SequenceSubStep subStep)
		{
		}
	}
}
