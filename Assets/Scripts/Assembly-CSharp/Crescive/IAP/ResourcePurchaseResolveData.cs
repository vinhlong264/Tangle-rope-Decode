using System;

namespace Crescive.IAP
{
	[Serializable]
	public class ResourcePurchaseResolveData
	{
		public ResourceProductInfo ResourceProductInfo;

		public ProductPurchaseResolveData ProductPurchaseResolveData;

		public ResourcePurchaseResolveData(ResourceProductInfo resourceProductInfo, ProductPurchaseResolveData productPurchaseResolveData)
		{
		}

		public bool IsResourceInfinite()
		{
			return false;
		}
	}
}
