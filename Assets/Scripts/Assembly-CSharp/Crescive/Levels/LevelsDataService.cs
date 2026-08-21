using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Levels/DataService/Levels Data Service", fileName = "LevelsDataService")]
	public class LevelsDataService : BaseLevelsDataService<LevelCreatorData>
	{
		protected override LevelsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LevelsData plainData)
		{
			return false;
		}
	}
}
