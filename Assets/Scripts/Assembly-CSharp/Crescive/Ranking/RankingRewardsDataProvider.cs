using Crescive.DataService;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "RankingRewardsDataProvider", menuName = "Crescive/Ranking/RankingRewardsDataProvider")]
	public class RankingRewardsDataProvider : RemoteConfigReferenceKeyDataProvider<RankingRewardsData>
	{
	}
}
