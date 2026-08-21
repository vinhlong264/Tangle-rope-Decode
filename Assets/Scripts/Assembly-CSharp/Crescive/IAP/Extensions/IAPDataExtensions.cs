using System.Collections.Generic;

namespace Crescive.IAP.Extensions
{
	public static class IAPDataExtensions
	{
		public static List<IPackInfo> GetAllPacksIncludingBundles(this IAPData data)
		{
			return null;
		}

		public static IPackInfo GetPackInfoIncludingBundles(this IAPData data, string packId)
		{
			return null;
		}

		public static IPackInfo GetPackInfoIncludingBundlesContainingProduct(this IAPData data, string productId)
		{
			return null;
		}

		public static List<ProductPack> GetAllProductPacks(this IAPData data)
		{
			return null;
		}

		public static List<ProductPack> GetAllAvailableProductPacks(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static ProductPack GetProductPack(this IAPData data, string id)
		{
			return null;
		}

		public static ProductPack GetProductPackContainingProduct(this IAPData data, string productId)
		{
			return null;
		}

		public static bool HasProductPackContainingProduct(this IAPData data, string productId)
		{
			return false;
		}

		public static List<BundlePack> GetAllBundlePacks(this IAPData data)
		{
			return null;
		}

		public static List<BundlePack> GetAllAvailableBundlePacks(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static List<BundlePack> GetAllAvailableBundlePacksInShop(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static BundlePack GetBundlePack(this IAPData data, string id)
		{
			return null;
		}

		public static BundlePack GetBundlePackContainingBundle(this IAPData data, string bundleId)
		{
			return null;
		}

		public static List<ProductInfo> GetAllProducts(this IAPData data)
		{
			return null;
		}

		public static List<IProductInfo> GetAllProductsIncludingBundles(this IAPData data)
		{
			return null;
		}

		public static List<ProductInfo> GetAllAvailableProducts(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static ProductInfo GetProductInfo(this IAPData data, string packId, string productId)
		{
			return null;
		}

		public static bool HasProduct(this IAPData data, string productId)
		{
			return false;
		}

		public static ProductInfo GetProductInfo(this IAPData data, string productId)
		{
			return null;
		}

		public static float GetProductPrice(this IAPData data, string productId)
		{
			return 0f;
		}

		public static IProductInfo GetProductInfoIncludingBundles(this IAPData data, string productId)
		{
			return null;
		}

		public static List<Bundle> GetAllBundles(this IAPData data)
		{
			return null;
		}

		public static List<Bundle> GetAllAvailableBundles(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static List<Bundle> GetBundlesIncludingProduct(this IAPData data, string productId)
		{
			return null;
		}

		public static List<Bundle> GetAvailableBundlesIncludingProduct(this IAPData data, string productId, IAPDataService service)
		{
			return null;
		}

		public static Bundle GetBundle(this IAPData data, string packId, string bundleId)
		{
			return null;
		}

		public static Bundle GetBundle(this IAPData data, string id)
		{
			return null;
		}

		public static bool IsUsingFakeReceipt(this IAPData data, string id)
		{
			return false;
		}

		public static bool HasFakeReceipt(this IAPData data, string id, List<string> fakeReceipts)
		{
			return false;
		}

		public static bool IsProductPurchased(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsBundlePurchased(string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsPurchased(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static List<ProductInfo> GetPurchasedProducts(this IAPData data, IAPDataService service)
		{
			return null;
		}

		public static bool IsProductAvailable(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsProductAvailableInShop(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsProductPackAvaiable(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsBundleAvailable(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsBundleAvailableInShop(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsBundlePackAvailable(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsBundlePackAvailableInShop(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailable(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailableInShop(this IAPData data, string id, IAPDataService service)
		{
			return false;
		}

		public static List<string> GetAllIds(this IAPData data)
		{
			return null;
		}

		public static bool HasId(this IAPData data, string id)
		{
			return false;
		}

		public static bool IsBundleId(this IAPData data, string id)
		{
			return false;
		}

		public static bool IsBundlePackId(this IAPData data, string id)
		{
			return false;
		}

		public static bool IsProductId(this IAPData data, string id)
		{
			return false;
		}

		public static bool IsProductPackId(this IAPData data, string id)
		{
			return false;
		}

		public static List<string> GetAllProductIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllProductIdsIncludingBundles(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableProductIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllProductPackIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableProductPackIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllBundlePackIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllPackIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableBundlePackIds(this IAPData data, IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllBundleIds(this IAPData data, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static List<string> GetAllAvailableBundleIds(this IAPData data, IAPDataService service, bool addEmptyToFirst = false)
		{
			return null;
		}

		public static IAPOfferPopUpSettings GetOfferPopUpSettings(this IAPData data, string id)
		{
			return null;
		}

		public static bool HasAvailableLimitedOffer(this IAPData data, string offerId)
		{
			return false;
		}

		public static LimitedOfferSettings GetLimitedOfferSettingsByProduct(this IAPData data, string productId)
		{
			return null;
		}

		public static List<LimitedOfferSettings> GetAllLimitedOfferSettings(this IAPData data)
		{
			return null;
		}

		public static LimitedOfferSettings GetLimitedOfferSettings(this IAPData data, string offerId)
		{
			return null;
		}

		public static List<LimitedOfferSettings> GetAvailableLimitedOfferSettings(this IAPData data)
		{
			return null;
		}

		public static bool IsLimitedOfferAvailableToShow(this IAPData data, string offerId, IAPDataService service)
		{
			return false;
		}

		public static bool IsTemporaryProductBundle(this IAPData data, string id)
		{
			return false;
		}

		public static bool IsTemporaryOriginalProduct(this IAPData data, string originalId)
		{
			return false;
		}

		public static TemporaryProductSettings GetTemporaryProductBundleSettings(this IAPData data, string id)
		{
			return null;
		}

		public static TemporaryProductSettings GetTemporaryOriginalProductSettings(this IAPData data, string originalId)
		{
			return null;
		}

		public static bool IsDiscountBundle(this IAPData data, string bundleId)
		{
			return false;
		}

		public static bool IsDiscountForProduct(this IAPData data, string bundleId)
		{
			return false;
		}

		public static bool IsDiscountForBundle(this IAPData data, string bundleId)
		{
			return false;
		}

		public static List<BundlePack> GetDiscountBundlePacks(this IAPData data)
		{
			return null;
		}

		public static List<Bundle> GetDiscountBundles(this IAPData data)
		{
			return null;
		}

		public static List<Bundle> GetDiscountBundlesForId(this IAPData data, string id)
		{
			return null;
		}

		public static bool HasAnyDiscountBundleContainingId(this IAPData data, string productId)
		{
			return false;
		}

		public static ProductInfo GetDiscountedProduct(this IAPData data, string bundleId)
		{
			return null;
		}

		public static Bundle GetDiscountedBundle(this IAPData data, string bundleId)
		{
			return null;
		}

		public static bool IsConditionalId(this IAPData data, string id)
		{
			return false;
		}

		public static ConditionalIdSettings GetConditionalIdSettings(this IAPData data, string id)
		{
			return null;
		}

		public static bool IsConditionalAndDisabled(this IAPData data, string id, CresciveBaseRemoteConfigSource remoteConfigSource, PersistentUserPayments savedPayments)
		{
			return false;
		}
	}
}
