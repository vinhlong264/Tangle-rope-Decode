using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CreatorModeAPI.Models;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace TwistedTangle.CreatorMode
{
	public static class CreatorApiService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPostLevelAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			public string url;

			public string levelJson;

			public CancellationToken ct;

			private object _003C_003Eu__1;

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

		public static IObservable<LevelModel> GetLevelAsObservable(string url, CancellationToken ct)
		{
			return null;
		}

		public static IObservable<string> PostLevelAsObservable(string url, string levelJson, CancellationToken ct)
		{
			return null;
		}

		public static IObservable<LevelModel> PutLevelAsObservable(string url, string levelJson, CancellationToken ct)
		{
			return null;
		}

		public static IObservable<LevelModel> PatchLevelAsObservable(string url, string levelJson, CancellationToken ct)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPostLevelAsync_003Ed__4))]
		public static UniTask<string> PostLevelAsync(string url, string levelJson, CancellationToken ct)
		{
			return default(UniTask<string>);
		}
	}
}
