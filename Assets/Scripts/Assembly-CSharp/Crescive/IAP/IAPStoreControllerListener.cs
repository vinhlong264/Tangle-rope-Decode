using Cysharp.Threading.Tasks;
using ElephantSDK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPStoreControllerListener : MonoBehaviour
	{
		[SerializeField]
		private IAPStoreControllerChannel controllerChannel;

		public UnityEvent OnInitializedEvent;

		public UnityEvent OnInitializeFailedEvent;

		public UnityEvent<ProductCollection> OnProductsFetchedEvent;

		public UnityEvent<string> OnInitiatePurchaseEvent;

		public UnityEvent<UniTask> OnInitiatePurchaseAsUniTaskEvent;

		public UnityEvent<Product> OnProcessingPurchaseEvent;

		public UnityEvent<Product> OnPurchaseCompletedEvent;

		public UnityEvent<string> OnDirectStorePurchaseCompletedEvent;

		public UnityEvent<Product> OnPurchaseCompletedWithoutVerificationEvent;

		public UnityEvent<Product, PurchaseFailureReason> OnPurchaseFailedEvent;

		public UnityEvent<Product> OnPurchaseFailedWithoutVerificationEvent;

		public UnityEvent<ElephantPaymentsError> OnDirectStorePurchaseFailedEvent;

		public UnityEvent<ElephantPaymentsError> OnDirectStorePurchaseFailedWithoutVerificationEvent;

		public UnityEvent<string> OnPurchaseProcessFinishedEvent;

		public UnityEvent<Product> OnPurchasedStateActiveEvent;

		public UnityEvent OnRequestRestoreEvent;

		public UnityEvent<UniTask> OnRequestRestoreAsyncEvent;

		public UnityEvent OnRestoreCompletedEvent;

		public UnityEvent<string> OnRestoreFailedWithMessageEvent;

		public UnityEvent<UniTask> OnRequestAnyAsyncEvent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PurchaseCompletedEvent(Product p)
		{
		}

		private void PurchaseCompletedWithoutVerificationEvent(Product p)
		{
		}

		private void PurchaseFailedEvent(Product p, PurchaseFailureReason r)
		{
		}

		private void PurchaseFailedWithoutVerificationEvent(Product p)
		{
		}

		private void DirectStorePurchaseFailedEvent(ElephantPaymentsError elephantPaymentsError)
		{
		}

		private void DirectStorePurchaseFailedWithoutVerificationEvent(ElephantPaymentsError elephantPaymentsError)
		{
		}
	}
}
