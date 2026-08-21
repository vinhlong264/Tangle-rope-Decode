using Crescive.CreatorMode;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(menuName = "Crescive/Earnings/GoldEarningDataService")]
	public class GoldEarningDataService : DataReadService<EarningSettingsData>
	{
		protected override EarningSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(EarningSettingsData plainData)
		{
			return false;
		}

		public int GetEarning(LevelCreatorSaveData saveData, int remainingMoveCount)
		{
			return 0;
		}
	}
}
