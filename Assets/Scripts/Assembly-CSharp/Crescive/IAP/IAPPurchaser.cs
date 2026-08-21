using Cysharp.Threading.Tasks;
using ElephantSDK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPPurchaser : BaseIAPBehaviour, IIAPPurchaser
	{
		[SerializeField]
		protected bool useFakeReceipt;

		[SerializeField]
		protected IAPSource source;

		public UnityEvent OnPurchaseInitiatedEvent;

		public UnityEvent<UniTask> OnPurchaseInitiatedAsyncEvent;

		public UnityEvent<Product> OnPurchaseCompletedEvent;

		public UnityEvent<string> OnDirectSalePurchaseCompletedEvent;

		public UnityEvent<Product> OnPurchaseCompletedWithoutVerificationEvent;

		public UnityEvent<Product, PurchaseFailureReason> OnPurchaseFailedEvent;

		public UnityEvent<ElephantPaymentsError> DirectStoreOnPurchaseFailedEvent;

		public void InitiatePurchase()
		{
		}

		public void OnPurchaseCompleted(Product product)
		{
		}

		public void OnPurchaseCompleted(string productID)
		{
		}

		public void OnPurchaseCompletedWithoutVerification(Product product)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}

		public void OnPurchaseFailed(ElephantPaymentsError elephantPaymentsError)
		{
		}

		public IAPSource GetSource()
		{
			return default(IAPSource);
		}

		public void SetSource(IAPSource s)
		{
		}

		public void SetUseFakeReceipt(bool value)
		{
		}
	}
}
