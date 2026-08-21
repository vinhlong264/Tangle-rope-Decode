using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Crescive.Navigation;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.Offer
{
	public class IAPOfferPopUpOfferEventsTriggerBehaviourSetup : BaseOfferEventsTriggerBehaviourSetup
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupInternal_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPOfferPopUpOfferEventsTriggerBehaviourSetup _003C_003E4__this;

			private IProductInfo _003CproductInfo_003E5__2;

			private UniTask<UnityEngine.Purchasing.Product>.Awaiter _003C_003Eu__1;

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
		private OfferEventsTriggerBehaviour offerEventsTriggerBehaviour;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private IAPOfferPopUp iapOfferPopUp;

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		private IAPPurchaser iapPurchaser;

		[AsyncStateMachine(typeof(_003CSetupInternal_003Ed__6))]
		protected override void SetupInternal()
		{
		}
	}
}
