using System;
using Crescive.MonetizationFeatures;

namespace Crescive.LadderOffer
{
	[Serializable]
	public class LadderOfferItemData : ICloneable
	{
		public string Type;

		public string BundleId;

		public OfferItemType TypeEnum => default(OfferItemType);

		public LadderOfferItemData(string type, string bundleId)
		{
		}

		public LadderOfferItemData(LadderOfferItemData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
