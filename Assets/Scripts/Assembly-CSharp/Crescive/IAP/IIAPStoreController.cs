using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public interface IIAPStoreController
	{
		void InitiatePurchase(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false);

		UniTask InitiatePurchaseAsync(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false);

		void Restore();

		UniTask RestoreAsync();

		Product GetProduct(string productId);

		UniTask<Product> GetProductAsync(string productId);

		UniTask<ProductCollection> GetProductsAsync();

		List<Product> GetPurchasedProducts();

		UniTask<List<Product>> GetPurchasedProductsAsync();

		bool HasReceipt(string productId);

		bool HasFakeReceipt(string productId);

		bool IsPurchased(string productId);

		void PerformFakePurchase(string productId);
	}
}
