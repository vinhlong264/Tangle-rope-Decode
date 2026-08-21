using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class TimeLimitController : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private IntReference timeLimit;

		[SerializeField]
		private BoolReference hasTimeLimit;

		[SerializeField]
		private FloatVariableReference outOfTimeDelay;

		[SerializeField]
		private List<BoolVariableReference> timeFrozenStates;

		[SerializeField]
		private IntReference playTime;

		[SerializeField]
		private IntReference performedTime;

		[SerializeField]
		private bool countDown;

		private bool isOutOfTime;

		private float oneSecondTimer;

		private float outOfTimeTimer;

		private float totalTime;

		private bool isCheckingOutOfTime;

		public UnityEvent OnTimeLimitZero;

		public UnityEvent OnTimeUp;

		public VoidEvent TimeUpAtomEvent;

		private bool IsTimeFrozen => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Pause()
		{
		}

		private void UpdatePlayTime()
		{
		}

		private void Countdown()
		{
		}

		private void StartCheckingOutOfTime()
		{
		}

		private void CheckOutOfTime()
		{
		}

		private void TryPerformingOutOfTime()
		{
		}

		public void StartCountdown()
		{
		}

		public void PauseCountdown()
		{
		}

		public void SetTimeLimit(int amount)
		{
		}

		public void IncreaseTimeLimit(int amount)
		{
		}

		public void ResetOutOfTimeAndStopCountdown()
		{
		}

		public void ResetAllData()
		{
		}

		public void KillOutOfTimeCheck()
		{
		}
	}
}
