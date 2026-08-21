using System;

namespace Crescive.IAP
{
	[Serializable]
	public class ProductPurchaseResolveData
	{
		public ProductInfo ProductInfo;

		public ProductPack ProductPack;

		public string info;

		public string productID;

		public ProductPurchaseResolveData(ProductInfo productInfo, ProductPack productPack)
		{
		}
	}
}
