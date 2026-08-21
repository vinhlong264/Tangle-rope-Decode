using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Channels;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/IAPStoreController/IAP Store Controller Channel")]
	public class IAPStoreControllerChannel : ObjectChannel<IAPStoreController>, IIAPStoreController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetProductAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<Product> _003C_003Et__builder;

			public IAPStoreControllerChannel _003C_003E4__this;

			public string productId;

			private UniTask<Product>.Awaiter _003C_003Eu__1;

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
		private struct _003CGetProductsAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ProductCollection> _003C_003Et__builder;

			public IAPStoreControllerChannel _003C_003E4__this;

			private UniTask<ProductCollection>.Awaiter _003C_003Eu__1;

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
		private struct _003CGetPurchasedProductsAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<Product>> _003C_003Et__builder;

			public IAPStoreControllerChannel _003C_003E4__this;

			private UniTask<List<Product>>.Awaiter _003C_003Eu__1;

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
		private struct _003CInitiatePurchaseAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreControllerChannel _003C_003E4__this;

			public IIAPPurchaser purchaser;

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
		private struct _003CRestoreAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAPStoreControllerChannel _003C_003E4__this;

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

		public void InitiatePurchase(IIAPPurchaser purchaser, string productId)
		{
		}

		[AsyncStateMachine(typeof(_003CInitiatePurchaseAsync_003Ed__1))]
		public UniTask InitiatePurchaseAsync(IIAPPurchaser purchaser, string productId)
		{
			return default(UniTask);
		}

		public void InitiatePurchase(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
		}

		public UniTask InitiatePurchaseAsync(IIAPPurchaser purchaser, string productId, bool useFakeReceipt = false)
		{
			return default(UniTask);
		}

		public void Restore()
		{
		}

		[AsyncStateMachine(typeof(_003CRestoreAsync_003Ed__5))]
		public UniTask RestoreAsync()
		{
			return default(UniTask);
		}

		public Product GetProduct(string productId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetProductAsync_003Ed__7))]
		public UniTask<Product> GetProductAsync(string productId)
		{
			return default(UniTask<Product>);
		}

		[AsyncStateMachine(typeof(_003CGetProductsAsync_003Ed__8))]
		public UniTask<ProductCollection> GetProductsAsync()
		{
			return default(UniTask<ProductCollection>);
		}

		public List<Product> GetPurchasedProducts()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPurchasedProductsAsync_003Ed__10))]
		public UniTask<List<Product>> GetPurchasedProductsAsync()
		{
			return default(UniTask<List<Product>>);
		}

		public bool HasReceipt(string productId)
		{
			return false;
		}

		public bool HasFakeReceipt(string productId)
		{
			return false;
		}

		public bool IsPurchased(string productId)
		{
			return false;
		}

		public void PerformFakePurchase(string productId)
		{
		}

		public void PerformFakePurchases(List<string> productIds)
		{
		}

		public void PerformFakePurchase(string productId, string battlepass)
		{
		}
	}
}
