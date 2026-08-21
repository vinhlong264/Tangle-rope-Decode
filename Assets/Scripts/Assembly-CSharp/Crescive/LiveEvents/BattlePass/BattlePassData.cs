using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class BattlePassData
	{
		public string? Id;

		public BattlePassStatus Status;

		public int Step;

		public int Tokens;

		public bool IsGoldenTicketPurchased;

		public int PendingTokens;

		public float PendingMultiplier;

		public int LastOpenedStep;

		public bool IsBonusCaseClaimed;

		public List<int> ClaimedFreeSteps;

		public List<int> ClaimedGoldenSteps;

		public bool IsFirstRewardClaimedTutorial;

		public bool IsProgressClickedTutorial;

		public bool IsGoldenTicketClickedTutorial;

		public int ActivationCount;

		public int Version;

		public bool IsTutorialFinished => false;

		public BattlePassData()
		{
		}

		public BattlePassData(BattlePassData? other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
