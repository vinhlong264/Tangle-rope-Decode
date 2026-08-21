using CresciveCore;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "LevelsData", menuName = "GameData/LevelsData", order = 0)]
	public class LevelsData : BaseLevelsData<LevelCreatorData>
	{
		public void LogLevelName(int levelNumber = 1)
		{
		}
	}
}
