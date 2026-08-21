using System.Collections.Generic;
using PersistentSO;

namespace Crescive.IAP.Extensions
{
	public static class IAPDataServiceExtensions
	{
		public static List<IPackInfo> GetAllPacksIncludingBundles(this IAPDataService service)
		{
			return null;
		}

		public static IPackInfo GetPackInfoIncludingBundles(this IAPDataService service, string packId)
		{
			return null;
		}

		public static IPackInfo GetPackInfoIncludingBundlesContainingProduct(this IAPDataService service, string productId)
		{
			return null;
		}

		public static List<ProductPack> GetAllProductPacks(this IAPDataService service)
		{
			return null;
		}

		public static List<ProductPack> GetAllAvailableProductPacks(this IAPDataService service)
		{
			return null;
		}

		public static ProductPack GetProductPack(this IAPDataService service, string id)
		{
			return null;
		}

		public static ProductPack GetProductPackContainingProduct(this IAPDataService service, string productId)
		{
			return null;
		}

		public static List<BundlePack> GetAllBundlePacks(this IAPDataService service)
		{
			return null;
		}

		public static List<BundlePack> GetAllAvailableBundlePacks(this IAPDataService service)
		{
			return null;
		}

		public static List<BundlePack> GetAllAvailableBundlePacksInShop(this IAPDataService service)
		{
			return null;
		}

		public static BundlePack GetBundlePack(this IAPDataService service, string id)
		{
			return null;
		}

		public static BundlePack GetbundlePackContainingBundle(this IAPDataService service, string bundleId)
		{
			return null;
		}

		public static List<ProductInfo> GetAllProducts(this IAPDataService service)
		{
			return null;
		}

		public static List<IProductInfo> GetAllProductsIncludingBundles(this IAPDataService service)
		{
			return null;
		}

		public static ProductInfo GetProductInfo(this IAPDataService service, string packId, string productId)
		{
			return null;
		}

		public static bool HasProduct(this IAPDataService service, string productId)
		{
			return false;
		}

		public static ProductInfo GetProductInfo(this IAPDataService data, string productId)
		{
			return null;
		}

		public static float GetProductPrice(this IAPDataService service, string productId)
		{
			return 0f;
		}

		public static IProductInfo GetProductInfoIncludingBundles(this IAPDataService service, string productId)
		{
			return null;
		}

		public static List<Bundle> GetAllBundles(this IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetAllAvailableBundles(this IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetBundlesIncludingProduct(this IAPDataService service, string productId)
		{
			return null;
		}

		public static List<Bundle> GetAvailableBundlesIncludingProduct(this IAPDataService service, string productId)
		{
			return null;
		}

		public static Bundle GetBundle(this IAPDataService service, string packId, string bundleId)
		{
			return null;
		}

		public static Bundle GetBundle(this IAPDataService service, string id)
		{
			return null;
		}

		public static bool IsUsingFakeReceipt(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool HasFakeReceipt(this IAPDataService service, string id, PersistentStringListVariable fakeReceipts)
		{
			return false;
		}

		public static bool IsProductPurchased(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundlePurchased(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsPurchased(this IAPDataService service, string id)
		{
			return false;
		}

		public static List<ProductInfo> GetPurchasedProducts(this IAPDataService service)
		{
			return null;
		}

		public static bool IsProductAvailable(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsProductAvailableInShop(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsProductPackAvailable(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundleAvailable(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundleAvailableInShop(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundlePackAvailable(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundlePackAvailableInShop(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsAvailable(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsAvailableInShop(this IAPDataService service, string id)
		{
			return false;
		}

		public static List<string> GetAllIds(this IAPDataService service)
		{
			return null;
		}

		public static bool HasId(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundleId(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsBundlePackId(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsProductId(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsProductPackId(this IAPDataService service, string id)
		{
			return false;
		}

		public static List<string> GetAllProductIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllProductIdsIncludingBundles(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableProductIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllProductPackIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableProductPackIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllBundlePackIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllPackIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableBundlePackIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllBundleIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableBundleIds(this IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static IAPOfferPopUpSettings GetOfferPopUpSettings(this IAPDataService service, string id)
		{
			return null;
		}

		public static bool HasAvailableLimitedOffer(this IAPDataService service, string id)
		{
			return false;
		}

		public static LimitedOfferSettings GetLimitedOfferSettingsByProduct(this IAPDataService service, string id)
		{
			return null;
		}

		public static List<LimitedOfferSettings> GetAllLimitedOfferSettings(this IAPDataService service)
		{
			return null;
		}

		public static LimitedOfferSettings GetLimitedOfferSettings(this IAPDataService service, string id)
		{
			return null;
		}

		public static List<LimitedOfferSettings> GetAvailableLimitedOfferSettings(this IAPDataService service)
		{
			return null;
		}

		public static bool IsLimitedOfferAvailableToShow(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsTemporaryProduct(this IAPDataService service, string id)
		{
			return false;
		}

		public static bool IsTemporaryProductForOriginalId(this IAPDataService service, string id)
		{
			return false;
		}

		public static TemporaryProductSettings GetTemporaryProductSettings(this IAPDataService service, string id)
		{
			return null;
		}

		public static TemporaryProductSettings GetTemporaryProductSettingsForOriginalId(this IAPDataService service, string id)
		{
			return null;
		}

		public static bool IsDiscountBundle(this IAPDataService service, string bundleId)
		{
			return false;
		}

		public static bool IsDiscountForProduct(this IAPDataService service, string bundleId)
		{
			return false;
		}

		public static bool IsDiscountForBundle(this IAPDataService service, string bundleId)
		{
			return false;
		}

		public static List<BundlePack> GetDiscountBundlePacks(this IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetDiscountBundles(this IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetDiscountBundlesForId(this IAPDataService service, string id)
		{
			return null;
		}

		public static bool HasAnyDiscountBundleContainingId(this IAPDataService service, string id)
		{
			return false;
		}

		public static ProductInfo GetDiscountedProduct(this IAPDataService service, string bundleId)
		{
			return null;
		}

		public static Bundle GetDiscountedBundle(this IAPDataService service, string bundleId)
		{
			return null;
		}

		public static bool IsConditionalId(this IAPDataService service, string id)
		{
			return false;
		}

		public static ConditionalIdSettings GetConditionalIdSettings(this IAPDataService service, string id)
		{
			return null;
		}

		public static bool IsConditionalAndDisabled(this IAPDataService service, string id)
		{
			return false;
		}
	}
}
