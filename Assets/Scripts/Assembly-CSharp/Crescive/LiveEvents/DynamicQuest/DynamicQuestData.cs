using System;

namespace Crescive.LiveEvents.DynamicQuest
{
	[Serializable]
	public class DynamicQuestData
	{
		public string Id;

		public bool IsLive;

		public int Step;

		public int Tokens;

		public int PendingTokens;

		public float PendingMultiplier;

		public bool IsGoldenPassPurchased;

		public bool IsGoldenPassActive;

		public int GoldenPassIntroLastShownStep;

		public DynamicQuestData(DynamicQuestData other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void ResetForEventActiveChange(string id, bool isActive)
		{
		}
	}
}
