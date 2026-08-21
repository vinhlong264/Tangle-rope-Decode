using System;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	[Serializable]
	public class CountAmountData : ICloneable
	{
		public int Count;

		public int Amount;

		public CountAmountData(int count, int amount)
		{
		}

		public CountAmountData(CountAmountData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
