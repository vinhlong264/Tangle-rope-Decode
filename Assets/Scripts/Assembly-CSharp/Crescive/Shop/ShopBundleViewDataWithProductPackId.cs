using System;
using System.Collections.Generic;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopBundleViewDataWithProductPackId
	{
		public string productPackId;

		public ShopProductType productType;

		public ShopBundleProductViewController view;

		private List<string> ProductPackIds => null;

		public string ProductPackId => null;

		public ShopProductType ProductType => null;

		public ShopBundleProductViewController View => null;
	}
}
