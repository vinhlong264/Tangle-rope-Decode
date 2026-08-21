using System.Collections.Generic;

namespace Crescive.IAP.Extensions
{
	public static class ProductPackExtensions
	{
		public static ProductInfo GetProductInfo(this ProductPack pack, string productId)
		{
			return null;
		}

		public static List<ProductInfo> GetShopProducts(this ProductPack pack, IAPDataService service)
		{
			return null;
		}

		public static bool HasAnyPurchasedProduct(this ProductPack pack, IAPDataService service)
		{
			return false;
		}

		public static bool HasAnyAvailableProduct(this ProductPack pack, IAPDataService service)
		{
			return false;
		}

		public static bool IsAnyDisablerProductPurchased(this ProductPack pack, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailable(this ProductPack pack, IAPDataService service, bool checkProducts = true)
		{
			return false;
		}
	}
}
