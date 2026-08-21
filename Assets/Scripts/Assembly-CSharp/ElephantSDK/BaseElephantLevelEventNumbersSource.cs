using UnityEngine;

namespace ElephantSDK
{
	public abstract class BaseElephantLevelEventNumbersSource : MonoBehaviour
	{
		public abstract int LevelNumber { get; }

		public abstract int LevelId { get; }

		public string LevelIdString => null;
	}
}
