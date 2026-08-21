using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.IAP
{
	public abstract class BaseIAPBehaviour : MonoBehaviour, IProductId
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BaseIAPBehaviour _003C_003E4__this;

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
		protected string productId;

		private CancellationTokenSource destroyTokenSource;

		protected IAPStoreController storeController;

		private List<string> ProductIds => null;

		public bool IsInitialized { get; private set; }

		public UniTask WaitUntilInitializedUniTask => default(UniTask);

		public string ProductId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CheckIsInitialized()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__15))]
		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void OnInitialized()
		{
		}

		protected virtual void OnProductIdChanged()
		{
		}

		public void SetProductId(string id)
		{
		}
	}
}
