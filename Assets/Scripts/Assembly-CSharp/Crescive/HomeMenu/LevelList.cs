using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.HomeMenu
{
	public class LevelList : MonoBehaviour
	{
		[SerializeField]
		private List<LevelItem> levelItems;

		[SerializeField]
		private IntVariableReference levelNumber;

		[SerializeField]
		private IntVariableReference actualLevelNumber;

		[SerializeField]
		[Space]
		private int levelStartIndex;

		[SerializeField]
		private int levelIndexOffsetBottom;

		[Space]
		[SerializeField]
		private bool disablePreviousLevels;

		[SerializeField]
		private int previousLevelsCount;

		[Space]
		[SerializeField]
		private bool reverseOnce;

		private bool _isInitialized;

		private void Awake()
		{
		}

		public void SetupItems()
		{
		}

		public void SetupNewItems()
		{
		}
	}
}
