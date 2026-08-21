using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using ElephantSDK;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPProductListener : BaseIAPBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTriggerEventsAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPProductListener _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public UnityEvent<string> OnInitiatePurchaseEvent;

		public UnityEvent<Product> OnProcessingPurchaseEvent;

		public UnityEvent<string> OnDirectStoreProcessingPurchaseEvent;

		public UnityEvent<Product> OnPurchaseCompletedEvent;

		public UnityEvent<string> OnDirectStorePurchaseCompletedEvent;

		public UnityEvent<Product, PurchaseFailureReason> OnPurchaseFailedEvent;

		public UnityEvent<ElephantPaymentsError> OnDirectStorePurchaseFailedEvent;

		public UnityEvent<Product> OnGetProduct;

		public UnityEvent<string> OnGetCurrency;

		public UnityEvent<string> OnGetLocalizedPrice;

		public UnityEvent<string> OnGetLocalizedTitle;

		public UnityEvent<string> OnGetLocalizedDescription;

		public UnityEvent<bool> OnGetHasReceipt;

		public UnityEvent OnGetHasReceiptSuccess;

		public UnityEvent OnGetHasReceiptFailed;

		public UnityEvent<string> OnGetReceipt;

		protected override void OnInitialized()
		{
		}

		protected override void OnProductIdChanged()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CTriggerEventsAsync_003Ed__20))]
		private void TriggerEventsAsync()
		{
		}

		private void PerformTriggerEvents()
		{
		}

		private void PerformTriggerReceiptEvents()
		{
		}

		private void OnInitiatePurchaseCallback(string id)
		{
		}

		private void OnProcessingPurchaseCallback(Product product)
		{
		}

		private void OnPurchaseCompletedCallback(Product product)
		{
		}

		private void OnDirectStorePurchaseCompletedCallback(string product)
		{
		}

		private void OnPurchaseFailedCallback(Product product, PurchaseFailureReason reason)
		{
		}

		private void OnDirectStorePurchaseFailedCallback(ElephantPaymentsError elephantPaymentsError)
		{
		}

		private void OnRestoreCompletedCallback()
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
