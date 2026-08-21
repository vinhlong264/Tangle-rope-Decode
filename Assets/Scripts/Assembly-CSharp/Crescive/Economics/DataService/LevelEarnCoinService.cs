using Crescive.DataService;
using UnityEngine;

namespace Crescive.Economics.DataService
{
	[CreateAssetMenu(fileName = "LevelEarnCoinService", menuName = "GameData/Coin/LevelEarnCoinService")]
	public class LevelEarnCoinService : DataReadService<LevelEarnCoinData>
	{
		protected override LevelEarnCoinData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LevelEarnCoinData plainData)
		{
			return false;
		}
	}
}
