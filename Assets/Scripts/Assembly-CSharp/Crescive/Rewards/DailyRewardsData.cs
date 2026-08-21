using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Rewards
{
	[CreateAssetMenu(fileName = "DailyRewardsData", menuName = "Crescive/DailyRewards/DailyRewardsData")]
	public class DailyRewardsData : ScriptableObject
	{
		[SerializeField]
		private List<BaseDailyRewardData> dailyRewardDatas;

		public BaseDailyRewardData GetDailyRewardDataByDayNumber(int dayNumber)
		{
			return null;
		}
	}
}
