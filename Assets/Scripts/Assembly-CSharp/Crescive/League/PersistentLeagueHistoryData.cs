using PersistentSO;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "PersistentLeagueHistoryData", menuName = "Crescive/League/PersistentLeagueHistoryData")]
	public class PersistentLeagueHistoryData : PersistentListVariable<LeagueHistoryData>
	{
		public override LeagueHistoryData GetItemCopy(LeagueHistoryData item)
		{
			return null;
		}
	}
}
