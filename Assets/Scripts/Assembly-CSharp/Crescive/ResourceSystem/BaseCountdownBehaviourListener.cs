using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class BaseCountdownBehaviourListener : MonoBehaviour
	{
		[SerializeField]
		private BaseCountdownBehaviour baseCountdownBehaviour;

		[SerializeField]
		private UnityEvent<float> OnTimerUpdated;

		[SerializeField]
		private UnityEvent<float> OnTimerUpdatedFloored;

		[SerializeField]
		private UnityEvent OnTimerStarted;

		[SerializeField]
		private UnityEvent<float> OnTimerStartedSeconds;

		[SerializeField]
		private UnityEvent OnTimerExpired;

		[SerializeField]
		private UnityEvent OnTimerEnabled;

		[SerializeField]
		private UnityEvent OnTimerDisabled;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTimerUpdatedCallback(float timeLeft)
		{
		}

		private void OnTimerStartedCallback()
		{
		}

		private void TriggerEnableDisableEvents()
		{
		}
	}
}
