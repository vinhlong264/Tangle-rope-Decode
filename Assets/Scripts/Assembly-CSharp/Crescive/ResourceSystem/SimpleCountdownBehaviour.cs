using System;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class SimpleCountdownBehaviour : BaseCountdownBehaviour
	{
		[SerializeField]
		private bool autoStart;

		[SerializeField]
		private FloatVariableReference autoStartTimeSeconds;

		[SerializeField]
		private bool useRealTime;

		[SerializeField]
		private bool isRunning;

		[SerializeField]
		private bool isEnabled;

		[SerializeField]
		private float timerSeconds;

		[SerializeField]
		private float timeLeft;

		[SerializeField]
		private bool didStartOnce;

		private DateTime targetEndTime;

		public override bool IsRunning => false;

		public override bool IsEnabled => false;

		public override float TimerSeconds => 0f;

		public override float TimerMinutes => 0f;

		public override float TimeLeft => 0f;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void StartTimer(float seconds, bool forceStart)
		{
		}

		public void StartTimer(float seconds)
		{
		}

		public void ForceStartTimer(float seconds)
		{
		}

		public void ResumeTimer()
		{
		}

		public void PauseTimer()
		{
		}

		public void ResetTimer(bool startIfDidStartOnce)
		{
		}

		public void EnableTimer()
		{
		}

		public void DisableTimer()
		{
		}
	}
}
