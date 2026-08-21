using PersistentSO;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(menuName = "Crescive/Ranking/Persistent/Persistent Ranking Entry Profile", fileName = "PersistentRankingEntryProfile")]
	public class PersistentRankingEntryProfile : PersistentVariable<RankingEntryProfileData>
	{
		public override RankingEntryProfileData GetCopy(RankingEntryProfileData value)
		{
			return null;
		}
	}
}
