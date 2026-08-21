using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CresciveCore.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Current Time Provider", menuName = "Crescive/Utils/Current Time Provider")]
	public class CurrentTimeProvider : SingletonSO<CurrentTimeProvider>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGet_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DateTime> _003C_003Et__builder;

			public bool getLocalTime;

			public CurrentTimeProvider _003C_003E4__this;

			public CancellationToken cancellationToken;

			private DateTime _003Cnow_003E5__2;

			private UniTask<(bool IsCanceled, UnityWebRequest Result)>.Awaiter _003C_003Eu__1;

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
		private string currentTimeAddress;

		private static bool HasNetwork => false;

		protected override void OnInitialize()
		{
		}

		protected override void OnDispose()
		{
		}

		private UniTask<UnityWebRequest> GetCurrentTimeFromServer(CancellationToken cancellationToken)
		{
			return default(UniTask<UnityWebRequest>);
		}

		[AsyncStateMachine(typeof(_003CGet_003Ed__6))]
		public UniTask<DateTime> Get(CancellationToken cancellationToken = default(CancellationToken), bool getLocalTime = true)
		{
			return default(UniTask<DateTime>);
		}
	}
}
