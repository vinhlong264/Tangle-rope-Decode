using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP
{
	public abstract class BaseItemPurchaseResolver : MonoBehaviour
	{
		[SerializeField]
		private BundlePurchaseResolver bundlePurchaseResolver;

		[SerializeField]
		private ProductPurchaseResolver productPurchaseResolver;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void ResolveBundle(BundlePurchaseResolverData data)
		{
		}

		protected abstract void ResolveProduct(ProductPurchaseResolveData data);

		protected abstract void ResolvePurchaseStateActiveProduct(ProductPurchaseResolveData data);

		protected abstract void ResolveProductUnclaim(ProductPurchaseResolveData data);

		private void ResolvePurchaseStateActiveProducts(List<ProductPurchaseResolveData> data)
		{
		}

		private void ResolveProducts(List<ProductPurchaseResolveData> data)
		{
		}

		private void ResolveProductsUnclaim(List<ProductPurchaseResolveData> data)
		{
		}
	}
}
