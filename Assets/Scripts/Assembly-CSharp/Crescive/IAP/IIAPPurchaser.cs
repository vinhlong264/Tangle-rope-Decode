using ElephantSDK;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public interface IIAPPurchaser
	{
		void InitiatePurchase();

		void OnPurchaseCompleted(Product product);

		void OnPurchaseCompletedWithoutVerification(Product product);

		void OnPurchaseFailed(Product product, PurchaseFailureReason reason);

		void OnPurchaseFailed(ElephantPaymentsError elephantPaymentsError);

		IAPSource GetSource();
	}
}
