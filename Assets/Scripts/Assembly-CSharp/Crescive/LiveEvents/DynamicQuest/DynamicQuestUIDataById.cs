using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public class DynamicQuestUIDataById
	{
		public string Id;

		public DynamicQuestUIData Data;

		private List<string> DynamicQuestIds => null;
	}
}
