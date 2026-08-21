using CresciveCore;
using UnityEngine;

namespace ElephantSDK
{
	public class NormalLevelNumbersSource : BaseElephantLevelEventNumbersSource
	{
		[SerializeField]
		private LevelSystem levelSystem;

		public override int LevelNumber => 0;

		public override int LevelId => 0;
	}
}
