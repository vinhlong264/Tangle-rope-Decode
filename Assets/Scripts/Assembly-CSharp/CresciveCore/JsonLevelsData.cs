using System;
using System.Collections.Generic;

namespace CresciveCore
{
	[Serializable]
	public class JsonLevelsData
	{
		public List<int> LevelOrder;

		public List<int> ExceptedLoopLevels;

		public JsonLevelsData(List<int> levelOrder, List<int> exceptedLoopLevels)
		{
		}
	}
}
