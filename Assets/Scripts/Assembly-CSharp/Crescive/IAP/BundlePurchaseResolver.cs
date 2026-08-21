using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

namespace Crescive.IAP
{
	public class BundlePurchaseResolver : BasePurchaseResolver
	{
		public UnityEvent<BundlePurchaseResolverData> OnInitiated;

		public UnityEvent<List<ProductPurchaseResolveData>> OnInitiatedProducts;

		[FormerlySerializedAs("OnResolvePurchase")]
		public UnityEvent<BundlePurchaseResolverData> OnResolveBundle;

		public UnityEvent<List<ProductPurchaseResolveData>> OnResolveProducts;

		public UnityEvent<List<ProductPurchaseResolveData>> OnResolvePurchaseStateActiveProducts;

		public UnityEvent<BundlePurchaseResolverData> OnResolveBundleUnclaim;

		public UnityEvent<List<ProductPurchaseResolveData>> OnResolveProductsUnclaim;

		private BundlePurchaseResolverData bundleResolveData;

		private List<ProductPurchaseResolveData> productsResolveData;

		protected override void InitiateResolve(string id, bool isBundle)
		{
		}

		protected override void CompleteResolve(string id, bool isBundle)
		{
		}

		protected override void ResolveFakePurchase(string id, bool isBundle)
		{
		}

		protected override void ResolveFakePurchase(string id, bool isBundle, string info)
		{
		}

		protected override void ResolvePurchasedStateActive(Product product, bool isBundle)
		{
		}

		protected override void ResolveUnclaimed(string id, bool isBundle)
		{
		}

		private BundlePurchaseResolverData GetBundleResolveData(Bundle bundle)
		{
			return null;
		}

		private BundlePurchaseResolverData GetBundleResolveUnclaimData(Bundle bundle)
		{
			return null;
		}

		private List<ProductPurchaseResolveData> GetProductsResolveDataList(Bundle bundle, bool useAvailableProducts = true)
		{
			return null;
		}

		private List<ProductPurchaseResolveData> GetProductsResolveUnclaimDataList(Bundle bundle, bool useAvailableProducts = true)
		{
			return null;
		}
	}
}
