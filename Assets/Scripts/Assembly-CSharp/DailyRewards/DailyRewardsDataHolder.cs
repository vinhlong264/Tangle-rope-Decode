using UnityEngine;

namespace DailyRewards
{
	[DefaultExecutionOrder(int.MinValue)]
	public class DailyRewardsDataHolder : MonoBehaviour
	{
		public static DailyRewardsDataHolder Instance;

		private DailyRewardsData dailyData;

		public static DailyRewardsData DailyRewardsData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}
	}
}
