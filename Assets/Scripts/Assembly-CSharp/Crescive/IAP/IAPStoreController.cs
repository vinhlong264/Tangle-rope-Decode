using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CresciveCore.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using ElephantSDK;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Crescive.IAP
{
	[DefaultExecutionOrder(-999)]
	public class IAPStoreController : Singleton<IAPStoreController>, IDetailedStoreListener, IStoreListener, IIAPStoreController
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			public IAPStoreController _003C_003E4__this;

			public Product product;

			internal void _003CVerifyIAP_003Eb__0(bool isVerified)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetProductAsync_003Ed__85 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<Product> _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			public string productId;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetProductsAsync_003Ed__86 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ProductCollection> _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPurchasedProductsAsync_003Ed__88 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<Product>> _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitiatePurchaseAsync_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			public IIAPPurchaser purchaser;

			public string productId;

			public bool useFakeReceipt;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitiatePurchaseInternalAsync_003Ed__74 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			public IIAPPurchaser purchaser;

			public string productId;

			public bool useFakeReceipt;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRestoreAsync_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRestoreInternalAsync_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CVerifyIAP_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPStoreController _003C_003E4__this;

			public Product product;

			private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[SerializeField]
		private PersistentStringListVariable fakeReceipts;

		[SerializeField]
		private bool useFakeVerification;

		[SerializeField]
		private BoolVariable fakeVerificationSource;

		[SerializeField]
		private StringCondition idExistsCondition;

		[SerializeField]
		private StringCondition nonConsumablePurchasedCondition;

		private CancellationTokenSource destroyTokenSource;

		private IStoreController storeController;

		private IAppleExtensions m_AppleExtensions;

		private IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;

		private IIAPPurchaser activePurchaser;

		private bool useFakeReceipt;

		private bool isRestoring;

		private bool isPurchaseInitiated;

		internal bool isLastActionInitiated;

		public UnityEvent OnInitializedEvent;

		public UnityEvent OnInitializeFailedEvent;

		public UnityEvent<ProductCollection> OnProductsFetchedEvent;

		public UnityEvent<string> OnInitiatePurchaseEvent;

		public UnityEvent<UniTask> OnInitiatePurchaseAsyncEvent;

		public UnityEvent<Product> OnProcessingPurchaseEvent;

		public UnityEvent<Product> OnPurchaseCompletedEvent;

		public UnityEvent<Product> OnPurchaseCompletedWithoutVerificationEvent;

		public UnityEvent<Product, PurchaseFailureReason> OnPurchaseFailedEvent;

		public UnityEvent<Product> OnPurchaseFailedWithoutVerificationEvent;

		public UnityEvent<string> OnPurchaseProcessFinishedEvent;

		public UnityEvent<ElephantPaymentsError> OnDirectStorePurchaseFailedEvent;

		public UnityEvent<ElephantPaymentsError> OnDirectStorePurchaseFailedWithoutVerificationEvent;

		public UnityEvent<Product> OnPurchasedStateActiveEvent;

		public UnityEvent OnRequestRestoreEvent;

		public UnityEvent<UniTask> OnRequestRestoreAsyncEvent;

		public UnityEvent OnRestoreCompletedEvent;

		public UnityEvent<string> OnRestoreFailedWithMessageEvent;

		public UnityEvent<UniTask> OnRequestAnyAsyncEvent;

		public UnityEvent<string, string> OnFakePurchasePerformedEvent;

		private bool ForceVerify => false;

		public bool IsInitialized { get; private set; }

		public UniTask WaitUntilInitializedUniTask => default(UniTask);

		public ProductCollection Products => null;

		public bool CheckIsInitialized()
		{
			return false;
		}

		protected override void OnInstanceCreated()
		{
		}

		protected override void OnInstanceDestroyed()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__47))]
		private void Start()
		{
		}

		private void Initialize()
		{
		}

		private bool IsDefaultCatalogContainsProduct(string productId)
		{
			return false;
		}

		private bool IsDefaultCatalogContainsProduct(Product product)
		{
			return false;
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return default(PurchaseProcessingResult);
		}

		[AsyncStateMachine(typeof(_003CVerifyIAP_003Ed__55))]
		private void VerifyIAP(Product product)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		public void OnPurchaseFailed(ElephantPaymentsError elephantPaymentsError)
		{
		}

		private void OnPurchaseVerified(Product product)
		{
		}

		private void OnPurchaseVerified(ElephantPayment pendingPurchase)
		{
		}

		private void SaveFakeReceiptIfNeeded(Product product)
		{
		}

		private void SaveFakeReceiptIfNeeded(string product)
		{
		}

		private void OnPurchaseVerifyFailed(Product product)
		{
		}

		private void OnPurchaseProcessFinished(Product product, bool success)
		{
		}

		private void OnPurchaseProcessFinished(string productID, bool success)
		{
		}

		private void OnPurchaseProcessFinished(ElephantPayment pendingPurchase, bool success)
		{
		}

		private void OnRestore(bool success, string error)
		{
		}

		private void FetchPurchasedProducts()
		{
		}

		private void InitiatePurchaseInternal(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
		}

		public void ApplyPurchase2(ElephantPayment pendingPurchase, IIAPPurchaser purchaser)
		{
		}

		private void DirectStoreOnPurchaseCompleted(ElephantPayment product, IIAPPurchaser purchaser)
		{
		}

		private void DirectStoreOnPurchaseFailed(ElephantPaymentsError error, IIAPPurchaser purchaser)
		{
		}

		private void DirectStoreOnPaymentDialogueClosed()
		{
		}

		[AsyncStateMachine(typeof(_003CInitiatePurchaseInternalAsync_003Ed__74))]
		private UniTask InitiatePurchaseInternalAsync(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
			return default(UniTask);
		}

		private void RestoreInternal()
		{
		}

		[AsyncStateMachine(typeof(_003CRestoreInternalAsync_003Ed__76))]
		private UniTask RestoreInternalAsync()
		{
			return default(UniTask);
		}

		private IapVerifyRequest GetIapVerifyRequest(Product purchasedProduct)
		{
			return null;
		}

		public void InitiatePurchase(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
		}

		[AsyncStateMachine(typeof(_003CInitiatePurchaseAsync_003Ed__79))]
		public UniTask InitiatePurchaseAsync(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
			return default(UniTask);
		}

		public void Restore()
		{
		}

		[AsyncStateMachine(typeof(_003CRestoreAsync_003Ed__81))]
		public UniTask RestoreAsync()
		{
			return default(UniTask);
		}

		public Product GetProduct(string productId)
		{
			return null;
		}

		public Product GetProduct2(string productId)
		{
			return null;
		}

		public bool HasProduct(string productId)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetProductAsync_003Ed__85))]
		public UniTask<Product> GetProductAsync(string productId)
		{
			return default(UniTask<Product>);
		}

		[AsyncStateMachine(typeof(_003CGetProductsAsync_003Ed__86))]
		public UniTask<ProductCollection> GetProductsAsync()
		{
			return default(UniTask<ProductCollection>);
		}

		public List<Product> GetPurchasedProducts()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPurchasedProductsAsync_003Ed__88))]
		public UniTask<List<Product>> GetPurchasedProductsAsync()
		{
			return default(UniTask<List<Product>>);
		}

		public bool HasReceipt(string productId)
		{
			return false;
		}

		public bool IsConsumable(string productId)
		{
			return false;
		}

		public void PerformFakePurchase(string productId)
		{
		}

		public void PerformFakePurchase(string productId, string battlepass)
		{
		}

		public void PerformFakePurchases(List<string> productIds)
		{
		}

		public bool HasFakeReceipt(string productId)
		{
			return false;
		}

		public bool IsPurchased(string productId)
		{
			return false;
		}

		public bool IsPurchased(Product product)
		{
			return false;
		}

		public string GetActivePurchaserSource()
		{
			return null;
		}
	}
}
