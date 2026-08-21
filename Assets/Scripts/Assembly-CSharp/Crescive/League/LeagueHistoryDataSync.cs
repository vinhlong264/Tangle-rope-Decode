using Crescive.Ranking;
using UnityEngine;

namespace Crescive.League
{
	public class LeagueHistoryDataSync : MonoBehaviour
	{
		[SerializeField]
		private PersistentLeagueHistoryData persistentLeagueHistoryData;

		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		[SerializeField]
		private PersistentRankingEntries persistentRankingEntries;

		[Space]
		[SerializeField]
		private int leagueHistoryCount;

		public void OnLeagueFinished()
		{
		}
	}
}
