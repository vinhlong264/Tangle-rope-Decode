using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class TimeFreezer : MonoBehaviour
	{
		[SerializeField]
		private BoolReference isTimeFrozen;

		[SerializeField]
		private BoolReference isTimeNotFrozen;

		[SerializeField]
		private BoolReference useDuration;

		[SerializeField]
		private FloatVariableReference timeFreezeDuration;

		[SerializeField]
		private List<BoolVariableReference> disableUpdateConditions;

		[SerializeField]
		private FloatReference timeFreezeTimer;

		public UnityEvent OnTimeFreezeStarted;

		public UnityEvent OnTimeFreezeFinished;

		public float TimeFreezeTimer => 0f;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void SetIsTimeFrozen(bool value)
		{
		}

		private void UpdateTimer()
		{
		}

		public void FreezeTime()
		{
		}

		public void StopFreezingTime()
		{
		}
	}
}
