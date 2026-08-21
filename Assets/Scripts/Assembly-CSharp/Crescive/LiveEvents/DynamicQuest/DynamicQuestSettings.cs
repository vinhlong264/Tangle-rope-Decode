using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public class DynamicQuestSettings : ICloneable
	{
		public string CurrentQuestId;

		public List<DynamicQuestConfig> Quests;

		private List<string> Ids => null;

		public DynamicQuestSettings(DynamicQuestSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public DynamicQuestConfig GetQuest(string id)
		{
			return null;
		}

		public DynamicQuestConfig GetCurrentQuest()
		{
			return null;
		}

		public bool HasQuest(string id)
		{
			return false;
		}
	}
}
