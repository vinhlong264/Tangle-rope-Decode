using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Crescive.DataService;
using CresciveCore;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Offer
{
	public class OfferController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestOffer_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public OfferController _003C_003E4__this;

			public bool dontTimeoutStoreController;

			public bool waitForTimeoutWhenNotShow;

			public bool dontTimeoutOfferRequest;

			private string _003CtriggerPoint_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private UniTask<(bool IsCanceled, ElephantSDK.OfferData Result)>.Awaiter _003C_003Eu__2;

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
		private struct _003CWaitForIAPStoreController_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public bool dontTimeoutStoreController;

			public OfferController _003C_003E4__this;

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

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private OfferRequester offerRequester;

		[SerializeField]
		private OfferRequestActions offerRequestActions;

		[Space]
		[SerializeField]
		private StringListDataService timeoutAsDelayTriggerPoints;

		[SerializeField]
		private StringListDataService noTimeoutStoreWaitTriggerPoints;

		[SerializeField]
		private StringListDataService noTimeoutOfferRequestTriggerPoints;

		private bool isRequesting;

		private CancellationTokenSource cancellationTokenSource;

		public UnityEvent OnBeforeRequestOffer;

		public UnityEvent OnRequestedOffer;

		public UnityEvent<OfferDataWrapper> OnOfferRequestResult;

		private CancellationToken CancellationToken => default(CancellationToken);

		public bool IsRequesting => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CRequestOffer_003Ed__19))]
		private void RequestOffer(bool waitForTimeoutWhenNotShow, bool dontTimeoutStoreController, bool dontTimeoutOfferRequest)
		{
		}

		private bool CheckSkinOffer()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CWaitForIAPStoreController_003Ed__21))]
		private Task WaitForIAPStoreController(bool dontTimeoutStoreController)
		{
			return null;
		}

		private void OnRequestCancelled(string message = null)
		{
		}

		private void OnTriggerPointValueChanged(string value)
		{
		}

		private void OnLoadingRequested()
		{
		}
	}
}
