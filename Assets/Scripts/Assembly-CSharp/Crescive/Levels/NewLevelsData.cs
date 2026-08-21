using System;
using System.Collections.Generic;

namespace Crescive.Levels
{
	[Serializable]
	public class NewLevelsData
	{
		public List<int> NewLevelNumbersOrdered;

		public List<int> NewLevelsNumbersUnique;

		public int MinLevelNumberOrdered => 0;

		public int MaxLevelNumberOrdered => 0;

		public bool NewLevelsAdded => false;

		public NewLevelsData(List<int> newLevelsNumbersUnique, List<int> newLevelNumbersOrdered)
		{
		}
	}
}
