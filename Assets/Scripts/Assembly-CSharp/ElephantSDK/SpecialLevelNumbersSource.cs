using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace ElephantSDK
{
	public class SpecialLevelNumbersSource : BaseElephantLevelEventNumbersSource
	{
		[SerializeField]
		private IntVariable displaySpecialLevelNumber;

		[SerializeField]
		private PersistentIntVariable currentSpecialLevelNumber;

		public override int LevelNumber => 0;

		public override int LevelId => 0;
	}
}
