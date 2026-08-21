using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public abstract class BaseLevelCreator<TCreatorData, TSaveData> : BaseCreator where TCreatorData : BaseLevelCreatorData<TSaveData> where TSaveData : BaseCreatorSaveData
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateLevel_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public BaseLevelCreator<TCreatorData, TSaveData> _003C_003E4__this;

			public TSaveData saveData;

			public int index;

			public bool cacheCurrentLevel;

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
		private struct _003CCreateLevel_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public BaseLevelCreator<TCreatorData, TSaveData> _003C_003E4__this;

			public TCreatorData creatorData;

			public int index;

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

		[CompilerGenerated]
		private sealed class _003CCreateLevelCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TSaveData saveData;

			public bool cacheCurrentLevel;

			public BaseLevelCreator<TCreatorData, TSaveData> _003C_003E4__this;

			public int index;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCreateLevelCoroutine_003Ed__16(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateLevelFromJson_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string json;

			public BaseLevelCreator<TCreatorData, TSaveData> _003C_003E4__this;

			public int index;

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
		private struct _003CReloadLevel_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BaseLevelCreator<TCreatorData, TSaveData> _003C_003E4__this;

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
		private List<BaseCreatorSaveDataProcessor<TSaveData>> saveDataProcessors;

		[SerializeField]
		private BoolReference isCreatingLevel;

		public UnityEvent OnLevelCreationStarted;

		public UnityEvent OnLevelCreated;

		public UnityEvent OnLevelReloaded;

		private TSaveData _currentSaveData;

		public bool IsCreatingLevel => false;

		public TSaveData CurrentSaveData => null;

		public int currentStageIndex { get; protected set; }

		public abstract void ResetLevel();

		protected abstract IEnumerator CreateLevelInternal(TSaveData creatorData, int index = 0);

		[IteratorStateMachine(typeof(BaseLevelCreator<, >._003CCreateLevelCoroutine_003Ed__16))]
		private IEnumerator CreateLevelCoroutine(TSaveData saveData, int index = 0, bool cacheCurrentLevel = true)
		{
			return null;
		}

		[AsyncStateMachine(typeof(BaseLevelCreator<, >._003CCreateLevel_003Ed__17))]
		public UniTask CreateLevel(TSaveData saveData, int index = 0, bool cacheCurrentLevel = true)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(BaseLevelCreator<, >._003CCreateLevel_003Ed__18))]
		public UniTask CreateLevel(TCreatorData creatorData, int index = 0)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(BaseLevelCreator<, >._003CCreateLevelFromJson_003Ed__19))]
		public override UniTask CreateLevelFromJson(string json, int index = 0)
		{
			return default(UniTask);
		}

		public void CreateLevelFromJsonClipBoard()
		{
		}

		[AsyncStateMachine(typeof(BaseLevelCreator<, >._003CReloadLevel_003Ed__21))]
		public void ReloadLevel()
		{
		}

		public void AddProcessor(BaseCreatorSaveDataProcessor<TSaveData> processor)
		{
		}

		public void RemoveProcessor(BaseCreatorSaveDataProcessor<TSaveData> processor)
		{
		}
	}
}
