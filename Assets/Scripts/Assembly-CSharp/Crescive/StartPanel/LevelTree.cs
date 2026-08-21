using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.StartPanel
{
	[DefaultExecutionOrder(1)]
	public class LevelTree : MonoBehaviour
	{
		[SerializeField]
		private List<LevelTreeItem> items;

		[SerializeField]
		private IntVariableReference currentLevelNumber;

		[SerializeField]
		private int levelStartIndex;

		[SerializeField]
		private int levelEndStartIndex;

		[SerializeField]
		private IntVariableReference lastLevelNumber;

		[SerializeField]
		private IntVariableReference realLastLevelNumber;

		private int CurrentLevelNumber => 0;

		private int LastLevelNumber => 0;

		private int RealLastLevelNumber => 0;

		public void SetupItems()
		{
		}
	}
}
