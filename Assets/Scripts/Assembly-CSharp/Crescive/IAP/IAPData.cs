using System;
using System.Collections.Generic;
using Crescive.DataService;

namespace Crescive.IAP
{
	[Serializable]
	public class IAPData : ICloneable, IMergeable<IAPData>
	{
		public List<ProductPack> ProductPacks;

		public List<BundlePack> BundlePacks;

		public List<ProductId> FakeReceiptIds;

		public List<IAPOfferPopUpSettings> OfferPopUpsSettings;

		public List<LimitedOfferSettings> LimitedOffers;

		public List<TemporaryProductSettingsPack> TemporaryProducts;

		public List<ConditionalIdSettingsPack> ConditionalIds;

		public IAPData(IAPData other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void Merge(IAPData other)
		{
		}

		public bool CanMergeWith(IAPData other)
		{
			return false;
		}
	}
}
