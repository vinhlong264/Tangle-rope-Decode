using PersistentSO;
using UnityEngine;

namespace Crescive.Rewards
{
	[CreateAssetMenu(fileName = "DailyRewardDataPersistentVariable", menuName = "Crescive/Persistent/DailyRewardStateData")]
	public class DailyRewardStateDataPersistentVariable : PersistentVariable<DailyRewardStateData>
	{
		public override DailyRewardStateData GetCopy(DailyRewardStateData value)
		{
			return default(DailyRewardStateData);
		}

		private void TestCollect()
		{
		}
	}
}
