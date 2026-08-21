using System;
using System.Collections.Generic;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class BattlePassConfig : ICloneable
	{
		public string? Id;

		public string? GoldenTicketId;

		public int BonusCaseTargetToken;

		public int BonusCaseAccumulateValue;

		public int BonusCaseMaxValue;

		public string? FirstFreeRewardId;

		public string? FirstGoldenTicketRewardId;

		public List<BattlePassTokenEarnAmountData>? TokenEarnAmounts;

		public List<int>? TargetTokens;

		public List<string>? FreeRewardIds;

		public List<string>? GoldenTicketRewardIds;

		private List<string> AllRewardIds => null;

		private List<string> AllTokenAmounts => null;

		public int GetStepCount()
		{
			return 0;
		}

		public int GetFirstStep()
		{
			return 0;
		}

		public int GetLastStep()
		{
			return 0;
		}

		public int GetNextStep(int currentStep)
		{
			return 0;
		}

		public int GetPreviousStep(int currentStep)
		{
			return 0;
		}

		public string? GetRewardId(int step, bool isGolden)
		{
			return null;
		}

		public int GetTokenEarnAmount(string difficulty)
		{
			return 0;
		}

		public int GetTargetTokens(int step)
		{
			return 0;
		}

		public int GetBonusCaseStep()
		{
			return 0;
		}

		public int GetBonusCaseStartStep()
		{
			return 0;
		}

		public int GetBonusCaseLastStep()
		{
			return 0;
		}

		public int GetTokensForDifficulty(string difficulty)
		{
			return 0;
		}

		public int? GetTokensAtStep(int step)
		{
			return null;
		}

		public virtual bool ValidateConfig(object obj)
		{
			return false;
		}

		public virtual bool ValidateObject(object obj)
		{
			return false;
		}

		public virtual bool IsValid(object obj)
		{
			return false;
		}

		public BattlePassConfig(BattlePassConfig? other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public override bool Equals(object? obj)
		{
			return false;
		}

		protected bool Equals(BattlePassConfig? other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
