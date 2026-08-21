using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.Collection
{
	public class PremiumCollectionItem : CollectionItem
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetDataInternal_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PremiumCollectionItem _003C_003E4__this;

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

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		private StringVariableInstancer priceVariable;

		[SerializeField]
		private StringVariableInstancer currencyVariable;

		private ProductInfo _productInfo;

		private Product _storeProduct;

		public string ProductId => null;

		public string LocalizedPriceString => null;

		public string IsoCurrencyCode => null;

		[AsyncStateMachine(typeof(_003CSetDataInternal_003Ed__12))]
		protected override UniTask SetDataInternal()
		{
			return default(UniTask);
		}

		protected override void SyncBindingsInternal()
		{
		}
	}
}
