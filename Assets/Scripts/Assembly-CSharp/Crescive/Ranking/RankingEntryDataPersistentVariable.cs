using PersistentSO;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "RankingEntryDataPersistentVariable", menuName = "Crescive/Persistent/RankingEntryData")]
	public class RankingEntryDataPersistentVariable : PersistentVariable<RankingEntryData>
	{
		public override RankingEntryData GetCopy(RankingEntryData value)
		{
			return null;
		}
	}
}
