using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Crescive.IAP;
using Crescive.ResourceSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Offer Requester", menuName = "Crescive/Offer/Offer Requester")]
	public class OfferRequester : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public OfferData offerData;

			public bool dontTimeoutOfferRequest;

			public OfferRequester _003C_003E4__this;

			public bool success;

			public float startTime;

			internal void _003CRequestOffer_003Eb__0(OfferData data)
			{
			}

			internal bool _003CRequestOffer_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public OfferData offerData;

			public bool success;

			internal void _003CRequestTestOffer_003Eb__0(OfferData data)
			{
			}

			internal bool _003CRequestTestOffer_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestOffer_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<OfferData> _003C_003Et__builder;

			public bool dontTimeoutOfferRequest;

			public OfferRequester _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

			public bool waitForTimeoutWhenNotShow;

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
		private struct _003CRequestTestOffer_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<OfferData> _003C_003Et__builder;

			public OfferRequester _003C_003E4__this;

			public CancellationToken ct;

			private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

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
		[Header("References")]
		private ResourceChannel coinResourceChannel;

		[SerializeField]
		private ResourceChannel heartResourceChannel;

		[SerializeField]
		private PersistentUserPayments persistentUserPayments;

		[SerializeField]
		private PersistentOffersData lastOffersData;

		[SerializeField]
		private StringVariable triggerPointValue;

		[Header("Settings")]
		[SerializeField]
		private FloatVariable offerRequestTimeout;

		[SerializeField]
		private FloatVariable offerShowStoreWaitTimeout;

		[SerializeField]
		private PersistentOfferTestMetaData testOfferMetaData;

		public StringVariable TriggerPointValue => null;

		public float OfferShowStoreWaitTimeout => 0f;

		public float OfferRequestTimeout => 0f;

		private CurrencyAmount GetCurrencyAmount()
		{
			return null;
		}

		private List<string> GetPurchasedProducts()
		{
			return null;
		}

		private int GetTotalCurrencyTransactionAmount()
		{
			return 0;
		}

		private int GetSessionCurrencyTransactionAmount()
		{
			return 0;
		}

		private int GetTotalIAPCount()
		{
			return 0;
		}

		private int GetSessionIAPCount()
		{
			return 0;
		}

		private float GetTotalIAPLTV()
		{
			return 0f;
		}

		private float GetSessionIAPLTV()
		{
			return 0f;
		}

		public OfferMetaData BuildOfferMetaData()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestOffer_003Ed__22))]
		public UniTask<OfferData> RequestOffer(bool waitForTimeoutWhenNotShow, bool dontTimeoutOfferRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<OfferData>);
		}

		[AsyncStateMachine(typeof(_003CRequestTestOffer_003Ed__24))]
		public UniTask<OfferData> RequestTestOffer(CancellationToken ct = default(CancellationToken))
		{
			return default(UniTask<OfferData>);
		}
	}
}
