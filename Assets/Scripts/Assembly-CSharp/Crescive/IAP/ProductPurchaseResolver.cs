using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

namespace Crescive.IAP
{
	public class ProductPurchaseResolver : BasePurchaseResolver
	{
		public UnityEvent<ProductPurchaseResolveData> OnInitiated;

		public UnityEvent<ProductPurchaseResolveData> OnResolved;

		public UnityEvent<ProductPurchaseResolveData> OnResolvedPurchaseStateActive;

		[FormerlySerializedAs("OnResolvedUnclaim")]
		public UnityEvent<ProductPurchaseResolveData> OnResolveUnclaim;

		private ProductPurchaseResolveData resolveData;

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

		private ProductPurchaseResolveData GetProductPurchaseResolveData(string id)
		{
			return null;
		}

		private ProductPurchaseResolveData GetProductPurchaseResolveUnclaimData(string id)
		{
			return null;
		}
	}
}
