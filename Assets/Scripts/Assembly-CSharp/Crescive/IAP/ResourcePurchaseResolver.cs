using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	public class ResourcePurchaseResolver : BaseItemPurchaseResolver
	{
		[SerializeField]
		private ResourcesProductSettings resourcesProductSettings;

		public UnityEvent<ResourcePurchaseResolveData, string> OnResolveResourcePurchase;

		public UnityEvent<ResourcePurchaseResolveData> OnResolveResourceStatePurchaseActive;

		public UnityEvent<ResourcePurchaseResolveData> OnResolveResourceUnclaim;

		protected override void ResolveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolvePurchaseStateActiveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolveProductUnclaim(ProductPurchaseResolveData data)
		{
		}

		private ResourcePurchaseResolveData GetResourcePurchaseResolveData(ProductPurchaseResolveData data)
		{
			return null;
		}
	}
}
