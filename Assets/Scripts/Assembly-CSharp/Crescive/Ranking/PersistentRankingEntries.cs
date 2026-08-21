using System.Collections.Generic;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(menuName = "Crescive/Ranking/Persistent/Persistent Ranking Entries", fileName = "PersistentRankingEntries")]
	public class PersistentRankingEntries : PersistentListVariable<RankingEntryData>
	{
		[SerializeField]
		private PersistentRankingEntryProfiles persistentRankingEntryProfiles;

		[SerializeField]
		private IntConstant playerRankId;

		public PersistentRankingEntryProfiles RankingEntryProfiles => null;

		public int PlayerRankId => 0;

		public override RankingEntryData GetItemCopy(RankingEntryData item)
		{
			return null;
		}

		public RankingEntryData GetRankingEntryData(int id)
		{
			return null;
		}

		public void SetRankingEntryData(RankingEntryData data)
		{
		}

		public RankingEntryProfileData GetRankingEntryProfileData(int id)
		{
			return null;
		}

		public List<RankingEntryData> GetOrderedEntries()
		{
			return null;
		}

		public int GetRankOfEntry(RankingEntryData entryData)
		{
			return 0;
		}

		public RankingEntryData GetPlayerRankEntryData()
		{
			return null;
		}

		public bool IsPlayerId(int id)
		{
			return false;
		}

		public int GetPlayerScore()
		{
			return 0;
		}

		public int GetPlayerRank()
		{
			return 0;
		}
	}
}
