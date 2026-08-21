using Cysharp.Threading.Tasks;
using ElephantSDK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPPurchaserListener : MonoBehaviour
	{
		[SerializeField]
		private IAPPurchaser iapPurchaser;

		public UnityEvent OnPurchaseInitiatedEvent;

		public UnityEvent<UniTask> OnPurchaseInitiatedAsyncEvent;

		public UnityEvent<Product> OnPurchaseCompletedEvent;

		public UnityEvent<string> OnDirectSalePurchaseCompletedEvent;

		public UnityEvent<Product> OnPurchaseCompletedWithoutVerificationEvent;

		public UnityEvent<Product, PurchaseFailureReason> OnPurchaseFailedEvent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ExecuteOnPurchaseFailedEvent(ElephantPaymentsError elephantPaymentsError)
		{
		}
	}
}
