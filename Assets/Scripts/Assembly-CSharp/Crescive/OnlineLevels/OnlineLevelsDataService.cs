using Crescive.DataService;
using UnityEngine;

namespace Crescive.OnlineLevels
{
	[CreateAssetMenu(fileName = "OnlineLevelsData", menuName = "Crescive/Online Levels/Online Levels Data", order = 0)]
	public class OnlineLevelsDataService : DataReadService<OnlineLevelsData>
	{
		protected override OnlineLevelsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(OnlineLevelsData plainData)
		{
			return false;
		}

		public OnlineLevelData GetLevel(int levelNumber)
		{
			return null;
		}

		public void AddLevelIdsFromClipboard()
		{
		}
	}
}
