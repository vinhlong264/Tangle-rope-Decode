using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.RaceSystem
{
	public class RaceEventsListener : MonoBehaviour
	{
		[SerializeField]
		private RaceSystem raceSystem;

		[SerializeField]
		private AutoTriggerMethod raceStatusTriggers;

		[SerializeField]
		private UnityEvent OnOfferRace;

		[SerializeField]
		private UnityEvent OnDeclineRace;

		[SerializeField]
		private UnityEvent OnAcceptRace;

		[SerializeField]
		private UnityEvent OnRaceStarted;

		[SerializeField]
		private UnityEvent OnRaceOngoing;

		[SerializeField]
		private UnityEvent OnRaceFinished;

		[SerializeField]
		private UnityEvent OnRaceFinishConfirmed;

		[SerializeField]
		private UnityEvent OnRaceUnavailable;

		private void Awake()
		{
		}

		private void T()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void TriggerRaceStatus()
		{
		}
	}
}
