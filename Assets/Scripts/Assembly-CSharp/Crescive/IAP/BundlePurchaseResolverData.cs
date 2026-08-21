using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class BundlePurchaseResolverData
	{
		public Bundle Bundle;

		public BundlePack BundlePack;

		public List<ProductPurchaseResolveData> ProductPurchaseResolverDataList;

		public string info;

		public BundlePurchaseResolverData(Bundle bundle, BundlePack bundlePack, List<ProductPurchaseResolveData> productPurchaseResolverDataList)
		{
		}
	}
}
