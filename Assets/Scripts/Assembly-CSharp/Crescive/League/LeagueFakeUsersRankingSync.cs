using System.Collections.Generic;
using Crescive.GameStates;
using Crescive.Ranking;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.League
{
	[DefaultExecutionOrder(-999)]
	public class LeagueFakeUsersRankingSync : MonoBehaviour
	{
		[SerializeField]
		private LiveLeagueDataService service;

		[SerializeField]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private PersistentRankingEntryProfiles rankingProfiles;

		[SerializeField]
		private RankingEntryProfileOptionsData profileOptionsData;

		[SerializeField]
		private PersistentStringVariable playerName;

		[SerializeField]
		private PersistentRankingEntryProfile playerRankingProfile;

		[SerializeField]
		private LeagueRankingConfig config;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private IntReference playerId;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnteredLeague()
		{
		}

		private void Sync()
		{
		}

		private void UpdateRankingEntries()
		{
		}

		private void AddNewRankingEntries()
		{
		}

		private List<RankingEntryData> CreateNewFakeEntries()
		{
			return null;
		}

		private List<int> GetRandomRankIds(int count, int startId, int endId = 10000)
		{
			return null;
		}

		private void SortRankingEntries(List<RankingEntryData> rankingEntryDatas)
		{
		}

		private void SyncEntriesToProfiles()
		{
		}
	}
}
