using System.Collections.Generic;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class RaceElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private RaceService raceService;

		[SerializeField]
		private RaceEvents raceEvents;

		private const string ShownEventName = "race_event_shown";

		private const string JoinedEventName = "race_event_joined";

		private const string RejectedEventName = "race_event_rejected";

		private const string FinishedEventName = "race_event_finished";

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private Dictionary<string, object> GetRaceFinishedEventParams(int playerRank)
		{
			return null;
		}

		private void SendRaceShownEvent()
		{
		}

		private void SendRaceJoinedEvent()
		{
		}

		private void SendRaceRejectedEvent()
		{
		}

		private void SendRaceFinishedEvent()
		{
		}
	}
}
