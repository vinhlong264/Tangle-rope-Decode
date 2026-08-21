using Crescive.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	public class SkinPurchaseResolver : BaseItemPurchaseResolver
	{
		[SerializeField]
		private SkinsProductSettings skinsProductSettings;

		public UnityEvent<SkinPurchaseResolveData> OnResolveSkinPurchase;

		public UnityEvent<SkinPurchaseResolveData> OnResolveSkinPurchaseStateActive;

		public UnityEvent<SkinPurchaseResolveData> OnResolveSkinUnclaim;

		protected override void ResolveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolvePurchaseStateActiveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolveProductUnclaim(ProductPurchaseResolveData data)
		{
		}

		private SkinPurchaseResolveData GetSkinPurchaseResolveData(ProductPurchaseResolveData data)
		{
			return null;
		}
	}
}
