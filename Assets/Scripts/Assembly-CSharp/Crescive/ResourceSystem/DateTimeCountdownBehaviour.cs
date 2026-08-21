using System;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class DateTimeCountdownBehaviour : BaseCountdownBehaviour
	{
		[SerializeField]
		private StringVariableReference lastTimeVariableReference;

		[SerializeField]
		private bool lastTimeIsEndTime;

		[SerializeField]
		private bool autoStart;

		[SerializeField]
		private FloatVariableReference autoStartTimeMinutes;

		[SerializeField]
		private bool isRunning;

		[SerializeField]
		private bool isEnabled;

		[SerializeField]
		private float timerSeconds;

		[SerializeField]
		private float timeLeft;

		private float timerMinutes;

		private DateTime lastTime;

		public override bool IsRunning => false;

		public override bool IsEnabled => false;

		public override float TimerSeconds => 0f;

		public override float TimerMinutes => 0f;

		public override float TimeLeft => 0f;

		private string LastTimeValue => null;

		public bool ShowAutoStartTimeMinutes => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void AutoStartTimer()
		{
		}

		public void StartTimer(float minutes)
		{
		}

		public void StopTimer()
		{
		}

		public void EnableTimer()
		{
		}

		public void DisableTimer()
		{
		}

		public void UpdateLastTime()
		{
		}
	}
}
