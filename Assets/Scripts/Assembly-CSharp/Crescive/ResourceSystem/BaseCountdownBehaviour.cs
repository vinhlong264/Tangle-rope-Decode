using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public abstract class BaseCountdownBehaviour : MonoBehaviour
	{
		public UnityEvent<float> OnTimerUpdated;

		public UnityEvent OnTimerStarted;

		public UnityEvent OnTimerExpired;

		public UnityEvent OnTimerEnabled;

		public UnityEvent OnTimerDisabled;

		public abstract bool IsRunning { get; }

		public abstract bool IsEnabled { get; }

		public abstract float TimerSeconds { get; }

		public abstract float TimerMinutes { get; }

		public abstract float TimeLeft { get; }
	}
}
