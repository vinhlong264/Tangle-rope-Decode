using Crescive.Ranking;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.League
{
	public class LeaguePlayerRankingProfileSync : MonoBehaviour
	{
		[SerializeField]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private PersistentStringVariable persistentPlayerName;

		[SerializeField]
		private PersistentRankingEntryProfile persistentPlayerProfile;

		[SerializeField]
		private IntReference playerEntryId;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPlayerNameChangedCallback(string playerName)
		{
		}

		private void OnPlayerProfileChangedCallback(RankingEntryProfileData profileData)
		{
		}
	}
}
