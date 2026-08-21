using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CreatorModeAPI.Models;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public class CreatorApiRequestLevelIntegration : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadLevelFromServerAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<LevelModel> _003C_003Et__builder;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			public string id;

			private UniTask<LevelModel>.Awaiter _003C_003Eu__1;

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
		private struct _003CPatchLevelToServerAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			public string id;

			private UniTask<LevelModel>.Awaiter _003C_003Eu__1;

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
		private struct _003CUpdateLevelToServerAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			private UniTask<LevelModel>.Awaiter _003C_003Eu__1;

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
		private struct _003CUpdateLevelToServerAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			public LevelCreatorSaveData levelData;

			private UniTask<LevelModel>.Awaiter _003C_003Eu__1;

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
		private struct _003CUploadLevelToServerAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			public string levelJson;

			private UniTask<string>.Awaiter _003C_003Eu__1;

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
		private struct _003CUploadLevelToServerAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public CreatorApiRequestLevelIntegration _003C_003E4__this;

			private UniTask<string>.Awaiter _003C_003Eu__1;

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
		private string baseUrl;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		private LevelSaverChannel levelSaverChannel;

		public UnityEvent OnAnyRequestStarted;

		public UnityEvent OnAnyRequestFinished;

		public UnityEvent OnAnyRequestFailed;

		public UnityEvent<string> OnGetCreatorLevelByIdStarted;

		public UnityEvent<string> OnGetCreatorLevelByIdFinished;

		public UnityEvent<string> OnGetCreatorLevelByIdFailed;

		public UnityEvent OnAddCreatorLevelStarted;

		public UnityEvent<string> OnAddCreatorLevelFinished;

		public UnityEvent OnAddCreatorLevelFailed;

		public UnityEvent<UniTask> OnRequesAnyAsync;

		private CancellationToken DestroyCancellationToken => default(CancellationToken);

		[AsyncStateMachine(typeof(_003CUploadLevelToServerAsync_003Ed__15))]
		public UniTask<string> UploadLevelToServerAsync(string levelJson)
		{
			return default(UniTask<string>);
		}

		[AsyncStateMachine(typeof(_003CUploadLevelToServerAsync_003Ed__16))]
		public Task<string> UploadLevelToServerAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateLevelToServerAsync_003Ed__17))]
		public UniTask UpdateLevelToServerAsync(string id)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CUpdateLevelToServerAsync_003Ed__18))]
		public UniTask UpdateLevelToServerAsync(string id, LevelCreatorSaveData levelData)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CPatchLevelToServerAsync_003Ed__19))]
		public UniTask PatchLevelToServerAsync(string id)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CDownloadLevelFromServerAsync_003Ed__20))]
		public UniTask<LevelModel> DownloadLevelFromServerAsync(string id)
		{
			return default(UniTask<LevelModel>);
		}

		public IObservable<LevelModel> DownloadLevelData(string id)
		{
			return null;
		}

		public UniTask<LevelModel> DownloadLevelDataAsUniTask(string id)
		{
			return default(UniTask<LevelModel>);
		}

		public void DownloadLevelFromServer(string id)
		{
		}

		public void UploadLevelToServer()
		{
		}

		public void DownloadLevelFromServerFromClipboard()
		{
		}
	}
}
