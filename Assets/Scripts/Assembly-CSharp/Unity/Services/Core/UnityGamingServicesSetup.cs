using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CresciveCore.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.Services.Core
{
	public class UnityGamingServicesSetup : Singleton<UnityGamingServicesSetup>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitUntilInitializedUniTask_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UnityGamingServicesSetup _003C_003E4__this;

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
		private bool autoInitializeOnAwake;

		[SerializeField]
		private bool retryOnFailure;

		[SerializeField]
		private string environmentId;

		[Header("Events")]
		public UnityEvent OnInitializeSuccess;

		public UnityEvent<string> OnInitializeError;

		public bool IsInitialized { get; private set; }

		public bool CheckIsInitialized()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CWaitUntilInitializedUniTask_003Ed__10))]
		public UniTask WaitUntilInitializedUniTask()
		{
			return default(UniTask);
		}

		protected override void OnInstanceCreated()
		{
		}

		protected override void OnInstanceDestroyed()
		{
		}

		private void Initialize()
		{
		}

		private void OnInitSuccess()
		{
		}

		private void OnInitError(string message)
		{
		}

		public void Initialize(Action onSuccess, Action<string> onError)
		{
		}
	}
}
