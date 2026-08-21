using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public class DynamicQuestConfig : ICloneable
	{
		public string Id;

		public bool GoldenPassEnabled;

		public string GoldenPassId;

		public int GoldenPassIntroPerStep;

		public int TokensByRope;

		public List<int> TargetTokens;

		public List<string> RewardIds;

		public List<string> GoldenPassRewardIds;

		private List<string> QuestIds => null;

		private List<string> IAPIds => null;

		public DynamicQuestConfig(DynamicQuestConfig other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public int GetLastStep()
		{
			return 0;
		}

		public int GetTargetTokens(int step, bool returnLastIfFinished = false)
		{
			return 0;
		}

		public int GetLastTargetToken()
		{
			return 0;
		}

		public int GetTotalTargetTokens()
		{
			return 0;
		}

		public string GetRewardId(int step, bool returnLastIfFinished = false)
		{
			return null;
		}

		public string GetGoldenPassRewardId(int step, bool returnLastIfFinished = false)
		{
			return null;
		}
	}
}
