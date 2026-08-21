using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.RaceSystem
{
	public class RaceDataListener : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private RaceSystem raceSystem;

		[Header("Settings")]
		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		[SerializeField]
		private bool triggerOnEnableIfTriggeredOnce;

		private bool didTriggerOnce;

		public UnityEvent<int> OnGetPlayerRank;

		public UnityEvent<float> OnGetRaceRemainingTime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void TriggerPlayerRank(int value)
		{
		}

		private void TriggerRaceRemainingTime(float value)
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
