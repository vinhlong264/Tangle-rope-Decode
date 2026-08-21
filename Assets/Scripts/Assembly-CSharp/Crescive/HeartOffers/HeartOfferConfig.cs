using System;

namespace Crescive.HeartOffers
{
	[Serializable]
	public class HeartOfferConfig : ICloneable
	{
		public string Type;

		public string Id;

		public HeartOfferConfig()
		{
		}

		public HeartOfferConfig(HeartOfferConfig other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
