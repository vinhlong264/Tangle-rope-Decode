using UnityEngine;

namespace Crescive.Rewards
{
	public abstract class BaseDailyRewardData : ScriptableObject
	{
		[field: SerializeField]
		public Sprite RewardIcon { get; private set; }

		[field: SerializeField]
		public string RewardInfo { get; private set; }

		public abstract void OnCollect();
	}
}
