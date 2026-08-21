using PersistentSO;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(menuName = "Crescive/Ranking/Persistent/Persistent Ranking Entry Profiles", fileName = "PersistentRankingEntryProfiles")]
	public class PersistentRankingEntryProfiles : PersistentListVariable<RankingEntryProfileData>
	{
		public override RankingEntryProfileData GetItemCopy(RankingEntryProfileData item)
		{
			return null;
		}

		public RankingEntryProfileData GetRankingEntryProfileData(int entryId)
		{
			return null;
		}

		public void SetRankingEntryProfileData(RankingEntryProfileData data)
		{
		}
	}
}
