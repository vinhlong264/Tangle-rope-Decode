using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Purchasing;

namespace Crescive.IAP.Extensions
{
	public static class IProductInfoExtensions
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetIAPProductAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<Product> _003C_003Et__builder;

			public IAPDataService service;

			public IProductInfo productInfo;

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

		public static Product GetIAPProduct(this IProductInfo productInfo, IAPDataService service)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetIAPProductAsync_003Ed__1))]
		public static UniTask<Product> GetIAPProductAsync(this IProductInfo productInfo, IAPDataService service)
		{
			return default(UniTask<Product>);
		}

		public static bool HasReceipt(this IProductInfo productInfo, IAPDataService service)
		{
			return false;
		}

		public static bool IsPurchased(this IProductInfo productInfo, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailable(this IProductInfo productInfo, IAPDataService service)
		{
			return false;
		}

		public static bool IsAvailableInShop(this IProductInfo productInfo, IAPDataService service)
		{
			return false;
		}

		public static bool HasProductPackContainingProduct(this IProductInfo productInfo, IAPData data)
		{
			return false;
		}

		public static ProductPack GetProductPack(this IProductInfo productInfo, IAPData data)
		{
			return null;
		}

		public static BundlePack GetBundlePack(this IProductInfo productInfo, IAPData data)
		{
			return null;
		}

		public static bool IsBundle(this IProductInfo productInfo, IAPData data)
		{
			return false;
		}

		public static bool HasDiscount(this IProductInfo productInfo, IAPData data)
		{
			return false;
		}

		public static List<Bundle> GetDiscountBundles(this IProductInfo productInfo, IAPData data)
		{
			return null;
		}
	}
}
