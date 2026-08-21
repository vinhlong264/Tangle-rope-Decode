using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.Rewards
{
	[CreateAssetMenu(fileName = "ResourceDailyRewardData", menuName = "Crescive/DailyReward/RewardData/ResourceDailyRewardData")]
	public class ResourceDailyRewardData : BaseDailyRewardData
	{
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private float amount;

		public override void OnCollect()
		{
		}
	}
}
