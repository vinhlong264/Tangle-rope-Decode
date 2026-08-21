using System.Collections.Generic;

namespace Crescive.IAP.Extensions
{
	public static class BundleExtensions
	{
		public static List<ProductInfo> GetProducts(this Bundle bundle, IAPData data)
		{
			return null;
		}

		public static List<ProductInfo> GetProductsRecursive(this Bundle bundle, IAPData data, bool includeTemporaryOriginalProduct = true)
		{
			return null;
		}

		public static List<Bundle> GetTemporaryProductBundlesRecursive(this Bundle bundle, IAPDataService dataService, bool isRecursiveCall = false)
		{
			return null;
		}

		public static List<ProductInfo> GetAvailableBundleProducts(this Bundle bundle, IAPDataService service, bool includeTemporaryOriginalProduct = true)
		{
			return null;
		}

		public static bool HasAvailableBundleProducts(this Bundle bundle, IAPDataService service)
		{
			return false;
		}

		public static bool HasProduct(this Bundle bundle, string id)
		{
			return false;
		}

		public static bool IsPurchased(this Bundle bundle, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailable(this Bundle bundle, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailableInShop(this Bundle bundle, IAPDataService service)
		{
			return false;
		}

		public static bool IsDiscount(this Bundle bundle, IAPData data)
		{
			return false;
		}
	}
}
