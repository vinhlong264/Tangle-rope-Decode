using System;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public struct DynamicQuestRewardRowSetupArgs
	{
		public DynamicQuestProgressPopupController Owner;

		public int RewardStep;

		public string RegularRewardId;

		public string GoldenPassRewardId;
	}
}
