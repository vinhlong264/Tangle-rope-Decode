using System;
using System.Collections.Generic;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopBundleViewDataWithProductId
	{
		public string productId;

		public ShopProductType productType;

		public ShopBundleProductViewController view;

		private List<string> ProductPackIds => null;

		public string ProductId => null;

		public ShopProductType ProductType => null;

		public ShopBundleProductViewController View => null;
	}
}
