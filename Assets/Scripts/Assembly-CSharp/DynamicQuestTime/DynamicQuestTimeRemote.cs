using System;
using System.Collections.Generic;

namespace DynamicQuestTime
{
	[Serializable]
	public class DynamicQuestTimeRemote
	{
		public int Level;

		public bool IsEnabled;

		public List<ItemData> rewards;

		public int StartDayOfWeek;

		public int EndDayOfWeek;

		public int MinTokenOnWin;

		public int MaxTokenOnWin;

		public List<int> CompleteTokenList;
	}
}
