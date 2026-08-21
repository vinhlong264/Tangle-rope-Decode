using System;

namespace Crescive.Data.PrizeProducts
{
	[Serializable]
	public class PrizeProductSettings : ICloneable
	{
		public bool Enabled;

		public string Id;

		public string ProductId;

		public PrizeProductSettings()
		{
		}

		public PrizeProductSettings(string id, string productId)
		{
		}

		public PrizeProductSettings(PrizeProductSettings settings)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
