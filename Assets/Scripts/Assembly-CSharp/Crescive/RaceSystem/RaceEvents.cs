using UnityEngine;
using UnityEngine.Events;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceEvents", menuName = "Crescive/Race System/Core/RaceEvents")]
	public class RaceEvents : ScriptableObject
	{
		public UnityEvent OnOfferRace;

		public UnityEvent OnDeclineRace;

		public UnityEvent OnAcceptRace;

		public UnityEvent OnRaceStarted;

		public UnityEvent OnRaceOngoing;

		public UnityEvent OnRaceFinished;

		public UnityEvent OnRaceFinishConfirmed;

		public UnityEvent OnRaceUnavailable;

		public void TriggerOfferRace()
		{
		}

		public void TriggerDeclineRace()
		{
		}

		public void TriggerAcceptRace()
		{
		}

		public void TriggerRaceStarted()
		{
		}

		public void TriggerRaceOngoing()
		{
		}

		public void TriggerRaceFinished()
		{
		}

		public void TriggerRaceFinishConfirmed()
		{
		}

		public void TriggerRaceUnavailable()
		{
		}
	}
}
