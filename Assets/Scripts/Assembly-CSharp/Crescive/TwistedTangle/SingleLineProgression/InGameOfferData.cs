using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	[Serializable]
	public class InGameOfferData
	{
		public List<float> CostByRepeat;

		public List<CountAmountData> ItemAmountByTryAgain;

		private InGameOfferData(List<float> costByRepeat, List<CountAmountData> itemAmountByTryAgain)
		{
		}

		public InGameOfferData(InGameOfferData other)
		{
		}

		public float GetCostByRepeat(int repeat)
		{
			return 0f;
		}

		public int GetItemAmountByTryAgain(int tryAgain)
		{
			return 0;
		}
	}
}
