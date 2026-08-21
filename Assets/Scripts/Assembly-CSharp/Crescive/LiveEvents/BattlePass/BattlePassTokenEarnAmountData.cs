using System;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class BattlePassTokenEarnAmountData : ICloneable
	{
		public string Difficulty;

		public int Tokens;

		public object Clone()
		{
			return null;
		}

		public BattlePassTokenEarnAmountData(BattlePassTokenEarnAmountData other)
		{
		}

		public object CreateCopy()
		{
			return null;
		}
	}
}
