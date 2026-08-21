using UnityEngine;

namespace CresciveCore
{
	public abstract class LevelNumberSettingsData
	{
		public Vector2Int levelStartEnd;

		public int interval;

		public bool IsLevelNumberInInterval(int levelNumber)
		{
			return false;
		}
	}
}
