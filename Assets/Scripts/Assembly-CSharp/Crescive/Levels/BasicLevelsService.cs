using Crescive.DataService;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Levels/BasicLevelsService")]
	public class BasicLevelsService : DataReadService<LevelListData>
	{
		protected override LevelListData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LevelListData plainData)
		{
			return false;
		}
	}
}
