using System;
using System.Collections.Generic;
using Crescive.Ranking;
using UnityEngine;

namespace Crescive.League
{
	public class LeagueElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private LiveLeagueDataService leagueService;

		[SerializeField]
		private PersistentRankingEntries rankEntries;

		[SerializeField]
		private PersistentLiveLeagueData liveLeagueData;

		[SerializeField]
		private float eventDelay;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnNewLeagueActivated()
		{
		}

		private void OnEnteredLeague()
		{
		}

		private void OnExitLeague()
		{
		}

		private void OnLeagueFinished()
		{
		}

		private Dictionary<string, object> GetPlayerRankParameters()
		{
			return null;
		}

		private Dictionary<string, object> GetPlayerAndLeagueParameters()
		{
			return null;
		}

		private Dictionary<string, object> GetLiveLeagueParameters()
		{
			return null;
		}

		private void SendEventDelayed(Action action)
		{
		}
	}
}
