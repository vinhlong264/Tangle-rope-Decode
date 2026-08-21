using System;
using System.Collections.Generic;

namespace Crescive.Data.PrizeProducts
{
	[Serializable]
	public class AllPrizeProductSettings
	{
		public List<PrizeProductSettings> All;

		public AllPrizeProductSettings()
		{
		}

		public AllPrizeProductSettings(AllPrizeProductSettings other)
		{
		}
	}
}
