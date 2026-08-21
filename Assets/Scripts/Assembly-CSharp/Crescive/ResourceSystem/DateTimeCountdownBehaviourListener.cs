using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class DateTimeCountdownBehaviourListener : MonoBehaviour
	{
		[SerializeField]
		private DateTimeCountdownBehaviour dateTimeCountdownBehaviour;

		[SerializeField]
		private UnityEvent<float> OnTimerUpdated;

		[SerializeField]
		private UnityEvent<float> OnTimerUpdatedFloored;

		[SerializeField]
		private UnityEvent OnTimerStarted;

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

		private void TriggerEnableDisableEvents()
		{
		}
	}
}
