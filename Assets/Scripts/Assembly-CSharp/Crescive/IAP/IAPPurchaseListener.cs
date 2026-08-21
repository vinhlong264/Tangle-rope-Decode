using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class IAPPurchaseListener : BaseIAPBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTriggerEventsAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPPurchaseListener _003C_003E4__this;

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
		private IAPDataService dataService;

		public UnityEvent OnPurchaseActive;

		public UnityEvent OnPurchaseInactive;

		public UnityEvent<bool> OnPurchaseStateChanged;

		public UnityEvent<bool> OnNotPurchaseStateChanged;

		protected override void OnInitialized()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CTriggerEventsAsync_003Ed__8))]
		private void TriggerEventsAsync()
		{
		}

		private void PerformTriggerEvents()
		{
		}

		private void OnPurchaseCompletedCallback(Product product)
		{
		}

		private void OnRestoreCompletedCallback()
		{
		}

		private void OnPurchaseProcessFinishedCallback(string id)
		{
		}
	}
}
