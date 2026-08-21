using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public abstract class BasePurchaseResolver : MonoBehaviour
	{
		[SerializeField]
		protected IAPDataService iapDataService;

		[SerializeField]
		protected IAPStoreControllerChannel storeControllerChannel;

		[SerializeField]
		protected TemporaryProductsResolver temporaryProductsResolver;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnInitiatePurchase(string id)
		{
		}

		private void OnPurchasedStateActive(Product product)
		{
		}

		private void OnPurchaseCompleted(Product product)
		{
		}

		private void OnPurchaseCompleted(string product)
		{
		}

		private void OnUnclaimResolved(string id)
		{
		}

		private void OnFakePurchasePerformed(string id, string info)
		{
		}

		private void OnRestoreCompleted()
		{
		}

		private bool IsBundle(string id)
		{
			return false;
		}

		private void InitiateResolve(string id)
		{
		}

		private void CompleteResolve(string id)
		{
		}

		protected abstract void InitiateResolve(string id, bool isBundle);

		protected abstract void CompleteResolve(string id, bool isBundle);

		protected abstract void ResolveFakePurchase(string id, bool isBundle);

		protected abstract void ResolveFakePurchase(string id, bool isBundle, string info);

		protected abstract void ResolvePurchasedStateActive(Product product, bool isBundle);

		protected abstract void ResolveUnclaimed(string id, bool isBundle);
	}
}
