using Crescive.Ranking;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.League
{
	public class LeaguePlayerRankingSync : MonoBehaviour
	{
		[SerializeField]
		private LiveLeagueDataService liveLeagueDataService;

		[SerializeField]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private LeagueRankingConfig config;

		[SerializeField]
		private IntReference playerId;

		public UnityEvent<float> OnPlayerScoreIncreased;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLeagueLevelCompleted()
		{
		}

		private void OnEnteredLeague()
		{
		}

		private void IncreasePlayerRanking()
		{
		}

		private int GetPlayerRankingScore()
		{
			return 0;
		}

		private void ResetPlayerRanking()
		{
		}

		private void SetPlayerRankingScore(int score)
		{
		}
	}
}
