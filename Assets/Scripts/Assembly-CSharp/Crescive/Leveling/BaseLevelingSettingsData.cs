using UnityEngine;

namespace Crescive.Leveling
{
	public abstract class BaseLevelingSettingsData
	{
		public Vector2Int levelStartEnd;

		public int interval;

		public bool IsLevelNumberInInterval(int levelNumber)
		{
			return false;
		}
	}
}
