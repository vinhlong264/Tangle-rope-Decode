using System.Collections.Generic;

namespace Crescive.IAP.Extensions
{
	public static class BundlePackExtensions
	{
		public static Bundle GetBundle(this BundlePack bundlePack, string id)
		{
			return null;
		}

		public static List<Bundle> GetAvailableInShopBundles(this BundlePack bundlePack, IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetAvailableBundles(this BundlePack bundlePack, IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetPurchasedBundles(this BundlePack bundlePack, IAPDataService service)
		{
			return null;
		}

		public static bool HasAnyAvailableBundle(this BundlePack bundlePack, IAPDataService service)
		{
			return false;
		}

		public static bool HasAnyAvailableInShopBundle(this BundlePack bundlePack, IAPDataService service)
		{
			return false;
		}

		public static bool HasAnyPurchasedBundle(this BundlePack bundlePack, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailable(this BundlePack bundlePack, IAPDataService service, bool checkBundles = true)
		{
			return false;
		}

		public static bool IsAvailableInShop(this BundlePack bundlePack, IAPDataService service)
		{
			return false;
		}
	}
}
