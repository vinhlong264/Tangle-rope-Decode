using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public class DynamicQuestRewardClaimViewArgs
	{
		public List<string> RegularRewards;

		public List<string> GoldenPassRewards;

		public List<string> AllRewards => null;

		public DynamicQuestRewardClaimViewArgs(List<string> regularRewards, List<string> goldenPassRewards)
		{
		}
	}
}
